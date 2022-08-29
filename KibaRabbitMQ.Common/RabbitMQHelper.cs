using RabbitMQ.Client;

namespace KibaRabbitMQ.Common
{
    public class RabbitMQHelper
    {
        private static ConnectionFactory factory;
        private static object lockObj = new object();
        /// <summary>
        /// 获取单个RabbitMQ连接
        /// </summary>
        /// <returns></returns>
        public static IConnection GetConnection()
        {
            if (factory == null)
            {
                lock (lockObj)
                {
                    if (factory == null)
                    {
                        factory = new ConnectionFactory
                        {
                            HostName = "127.0.0.1",      //ip
                            Port = 5672,                   //端口
                            UserName = "admin",            //账号
                            Password = "123456",           //密码
                            VirtualHost = "develop"        //虚拟主机
                        };
                    }
                }
            }
            return factory.CreateConnection();
        }
    }
}