namespace KibaRabbitMQ._6.RPC模式
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
        private void SendMessage_Click(object sender, EventArgs e)
        {
            //启动服务端，正常逻辑是在另一个程序
            Task.Run(() =>
            {
                RPCServer.RpcHandle(richTextBox1);
            });
        }

        /// <summary>
        /// 消息消费者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReceiveMessage_Click(object sender, EventArgs e)
        {
            //实例化客户端
            var rpcClient = new RPCClient();
            string message = $"消息id:{new Random().Next(1, 1000)}";
            richTextBox2.AppendText($"【客服端】RPC请求中，{message}" + "\r\n");
            //向服务端发送消息，等待回复
            var response = rpcClient.Call(message);
            richTextBox2.AppendText($"【客服端】收到回复响应:{response}" + "\r\n");
            rpcClient.Close();
            Console.ReadKey();
        }
    }
}