// See https://aka.ms/new-console-template for more information
using KibaRabbitMQ._6.RPC模式;

Console.WriteLine("Hello, World!"); 
//启动服务端，正常逻辑是在另一个程序
RPCServer.RpcHandle();
//实例化客户端
var rpcClient = new RPCClient();
string message = $"消息id:{new Random().Next(1, 1000)}";
Console.WriteLine($"【客服端】RPC请求中，{message}");
//向服务端发送消息，等待回复
var response = rpcClient.Call(message);
Console.WriteLine("【客服端】收到回复响应:{0}", response);
rpcClient.Close();
Console.ReadKey();