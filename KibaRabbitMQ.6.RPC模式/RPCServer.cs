using KibaRabbitMQ.Common;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibaRabbitMQ._6.RPC模式
{
    public class RPCServer
    {
        public static void RpcHandle(RichTextBox richTextBox)
        {

            var connection = RabbitMQHelper.GetConnection();
            {
                var channel = connection.CreateModel();
                {
                    Action<string> setValue = (msg) => { richTextBox.AppendText(msg); };

                    string queueName = "rpc_queue";
                    channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
                    channel.BasicQos(0, 1, false);
                    var consumer = new EventingBasicConsumer(channel);
                    channel.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);

                    richTextBox.Invoke(setValue,"【服务端】等待RPC请求..." + "\r\n");

                    consumer.Received += (model, ea) =>
                    {
                        string response = null;

                        var body = ea.Body.ToArray();
                        var props = ea.BasicProperties;
                        var replyProps = channel.CreateBasicProperties();
                        replyProps.CorrelationId = props.CorrelationId;

                       
                        try
                        {
                            var message = Encoding.UTF8.GetString(body);
                            richTextBox.Invoke(setValue, $"【服务端】接收到数据:{ message},开始处理" + "\r\n");
                            response = $"消息:{message},处理完成";
                        }
                        catch (Exception e)
                        {
                            richTextBox.Invoke(setValue, "错误:" + e.Message + "\r\n");
                            response = "";
                        }
                        finally
                        {
                            var responseBytes = Encoding.UTF8.GetBytes(response);
                            channel.BasicPublish(exchange: "", routingKey: props.ReplyTo, basicProperties: replyProps, body: responseBytes);
                            channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                        }
                    };
                }
            }
        }
    }
}
