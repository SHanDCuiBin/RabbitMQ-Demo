using KibaRabbitMQ.Common;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace KibaRabbitMQ._5.topics主题模式
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
        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            //创建连接
            using (var connection = RabbitMQHelper.GetConnection())
            {
                //创建信道
                using (var channel = connection.CreateModel())
                {
                    //声明交换机对象,fanout类型
                    string exchangeName = "topic_exchange";
                    channel.ExchangeDeclare(exchangeName, ExchangeType.Topic);
                    //队列名
                    string queueName1 = "topic_queue1";
                    string queueName2 = "topic_queue2";
                    //路由名
                    string routingKey1 = "*.orange.*";
                    string routingKey2 = "*.*.rabbit";
                    string routingKey3 = "lazy.#";
                    channel.QueueDeclare(queueName1, true, false, false);
                    channel.QueueDeclare(queueName2, true, false, false);

                    //把创建的队列绑定交换机,routingKey指定routingKey
                    channel.QueueBind(queue: queueName1, exchange: exchangeName, routingKey: routingKey1);
                    channel.QueueBind(queue: queueName2, exchange: exchangeName, routingKey: routingKey2);
                    channel.QueueBind(queue: queueName2, exchange: exchangeName, routingKey: routingKey3);
                    //向交换机写10条消息
                    for (int i = 0; i < 10; i++)
                    {
                        string message = $"RabbitMQ Direct {i + 1} Message";
                        var body = Encoding.UTF8.GetBytes(message);
                        channel.BasicPublish(exchangeName, routingKey: "aaa.orange.rabbit", null, body);
                        channel.BasicPublish(exchangeName, routingKey: "lazy.aa.rabbit", null, body);

                        rBoxSendMessage.AppendText($"发送Topic消息:{message}" + "\r\n");
                    }
                }
            }
        }

        /// <summary>
        /// 消息消费者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceiveMessage_Click(object sender, EventArgs e)
        {
            WorkerConsumer(rBoxReceive1, "topic_queue1");
            WorkerConsumer(rBoxReceive2, "topic_queue2");
        }

        public void WorkerConsumer(RichTextBox richTextBox, string queueName)
        {
            var connection = RabbitMQHelper.GetConnection();
            {
                //创建信道
                var channel = connection.CreateModel();
                {
                    //创建队列
                    channel.QueueDeclare(queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
                    var consumer = new EventingBasicConsumer(channel);
                    ///prefetchCount:1来告知RabbitMQ,不要同时给一个消费者推送多于 N 个消息，也确保了消费速度和性能
                    ///global：是否设为全局的
                    ///prefetchSize:单条消息大小，通常设0，表示不做限制
                    //是autoAck=false才会有效
                    channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: true);
                    int i = 1;
                    Action<string> setValue = (msg) => { richTextBox.AppendText(msg); };
                    consumer.Received += (model, ea) =>
                    {
                        //处理业务
                        var message = Encoding.UTF8.GetString(ea.Body.ToArray());
                        richTextBox.Invoke(setValue, $"{i},队列{queueName}消费消息长度:{message.Length}" + "\r\n");
                        channel.BasicAck(ea.DeliveryTag, false); //消息ack确认，告诉mq这条队列处理完，可以从mq删除了
                        i++;
                    };
                    channel.BasicConsume(queueName, autoAck: false, consumer);
                }
            }
        }
    }
}