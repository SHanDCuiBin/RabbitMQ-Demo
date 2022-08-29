using KibaRabbitMQ.Common;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace KibaRabbitMQ._3.PulishSubscribe发布订阅模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 生产者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            //创建连接
            using (var connection = RabbitMQHelper.GetConnection())
            {
                //创建信道
                using (var channel = connection.CreateModel())
                {
                    string exchangeName = "fanout_exchange";
                    //创建交换机,fanout类型
                    channel.ExchangeDeclare(exchangeName, ExchangeType.Fanout, true);
                    string queueName1 = "fanout_queue1";
                    string queueName2 = "fanout_queue2";
                    string queueName3 = "fanout_queue3";
                    //创建队列
                    channel.QueueDeclare(queueName1, true, false, false);
                    channel.QueueDeclare(queueName2, true, false, false);
                    channel.QueueDeclare(queueName3, true, false, false);

                    //把创建的队列绑定交换机,routingKey不用给值，给了也没意义的
                    channel.QueueBind(queue: queueName1, exchange: exchangeName, routingKey: "");
                    channel.QueueBind(queue: queueName2, exchange: exchangeName, routingKey: "");
                    channel.QueueBind(queue: queueName3, exchange: exchangeName, routingKey: "");
                    var properties = channel.CreateBasicProperties();
                    properties.Persistent = true; //消息持久化
                    //向交换机写10条消息
                    for (int i = 0; i < 10; i++)
                    {
                        string message = $"RabbitMQ Fanout {i + 1} Message";
                        var body = Encoding.UTF8.GetBytes(message);
                        channel.BasicPublish(exchangeName, routingKey: "", null, body);
                        rBoxSendMessage.AppendText($"发送Fanout消息:{message}" + "\r\n");
                    }
                }
            }
        }


        /// <summary>
        /// 订阅者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceiveMessage_Click(object sender, EventArgs e)
        {
            WorkerConsumer(rBoxReceiveMesssage1, "fanout_queue1");
            WorkerConsumer(rBoxReceiveMesssage2, "fanout_queue2");
            WorkerConsumer(rBoxReceiveMesssage3, "fanout_queue3");
        }

        public void WorkerConsumer(RichTextBox richTextBox, string queueName)
        {
            var connection = RabbitMQHelper.GetConnection();
            {
                //创建信道
                var channel = connection.CreateModel();
                {
                    //创建队列  生产者创建了，消费者就不需要创建了
                    // channel.QueueDeclare(queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
                    var consumer = new EventingBasicConsumer(channel);
                    //prefetchCount:1来告知RabbitMQ,不要同时给一个消费者推送多于 N 个消息，也确保了消费速度和性能
                    channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);
                    int i = 1;
                    int index = new Random().Next(10);
                    Action<string> setValue = (msg) => { richTextBox.AppendText(msg); };
                    consumer.Received += (model, ea) =>
                    {
                        //处理业务
                        var message = Encoding.UTF8.GetString(ea.Body.ToArray());
                        richTextBox.Invoke(setValue, $"{i},消费者:{index},队列{queueName}消费消息长度:{message.Length}" + "\r\n");
                        channel.BasicAck(ea.DeliveryTag, false); //消息ack确认，告诉mq这条队列处理完，可以从mq删除了
                        Thread.Sleep(1000);
                        i++;
                    };
                    channel.BasicConsume(queueName, autoAck: false, consumer);
                }
            }
        }
    }
}