using KibaRabbitMQ.Common;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace KibaRabbitMQ._2.Work工作模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1个生产者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            string queueName = "worker_order";//队列名
            //创建连接
            using (var connection = RabbitMQHelper.GetConnection())
            {
                //创建信道
                using (var channel = connection.CreateModel())
                {
                    //创建队列
                    channel.QueueDeclare(queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
                    var properties = channel.CreateBasicProperties();
                    properties.Persistent = true; //消息持久化
                    for (var i = 0; i < 10; i++)
                    {
                        string message = $"Hello RabbitMQ MessageHello,{i + 1}";
                        var body = Encoding.UTF8.GetBytes(message);
                        //发送消息到rabbitmq
                        channel.BasicPublish(exchange: "", routingKey: queueName, mandatory: false, basicProperties: properties, body);
                        rBoxSendMessage.AppendText($"发送消息到队列:{queueName},内容:{message}" + "\r\n");
                    }
                }
            }
        }


        /// <summary>
        /// 多个消费者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceiveMessage_Click(object sender, EventArgs e)
        {
            WorkerConsumer(rBoxReceive1);
            WorkerConsumer(rBoxReceive2);
            WorkerConsumer(rBoxReceive3);
        }

        /// <summary>
        /// 消费者消费方法
        /// </summary>
        /// <param name="richTextBox"></param>
        public void WorkerConsumer(RichTextBox richTextBox)
        {
            string queueName = "worker_order";
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