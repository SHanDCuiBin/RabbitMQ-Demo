using KibaRabbitMQ.Common;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace KibaRabbitMQ.Simple模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 消息生产者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string queueName = "simple_order";//队列名
            //创建连接
            using (var connection = RabbitMQHelper.GetConnection())
            {
                //创建信道
                using (var channel = connection.CreateModel())
                {   //创建队列
                    /* 创建队列参数解析：
                     durable：   是否持久化。
                     exclusive： 排他队列，只有创建它的连接(connection)能连，创建它的连接关闭，会自动删除队列。
                     autoDelete：被消费后，消费者数量都断开时自动删除队列。
                     arguments： 创建队列的参数。*/
                    channel.QueueDeclare(queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
                    for (var i = 0; i < 10; i++)
                    {
                        string message = $"Hello RabbitMQ MessageHello,{i + 1}";
                        var body = Encoding.UTF8.GetBytes(message);
                        //发送消息
                        /*发送消息参数解析：
                        exchange：  交换机，为什么能传空呢，因为RabbitMQ内置有一个默认的交换机，如果传空时，就会用默认交换机。
                        routingKey：路由名称，这里用队列名称做路由key。
                        mandatory： true告诉服务器至少将消息route到一个队列中，否则就将消息return给发送者；false：没有找到路由则消息丢弃 */
                        channel.BasicPublish(exchange: "", routingKey: queueName, mandatory: false, basicProperties: null, body);
                        rBoxSend.AppendText($"发送消息到队列:{queueName},内容:{message}" + "\r\n");
                    }
                }
            }
        }

        /// <summary>
        /// 消息消费者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string queueName = "simple_order";
            var connection = RabbitMQHelper.GetConnection();
            {
                //创建信道
                var channel = connection.CreateModel();
                {
                    //创建队列
                    channel.QueueDeclare(queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
                    var consumer = new EventingBasicConsumer(channel);
                    int i = 0;
                    Action<string> setValue = (msg) => { rBoxReceiveMessage.AppendText(msg); };
                    consumer.Received += (model, ea) =>
                    {
                        //消费者业务处理
                        var message = Encoding.UTF8.GetString(ea.Body.ToArray());
                        rBoxReceiveMessage.Invoke(setValue, $"{i},队列{queueName} 长度:{message.Length} 内容:{message}" + "\r\n");
                        i++;
                    };
                    channel.BasicConsume(queueName, true, consumer);
                }
            }
        }
    }
}