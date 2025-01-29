using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost" };
var connection = await factory.CreateConnectionAsync();
using (connection)
using (var channel = await connection.CreateChannelAsync())
{
    await channel.QueueDeclareAsync(
        queue: "BasicTest",
        durable: false,
        exclusive: false,
        autoDelete: false,
        arguments: null);

    string message = "Getting started with .Net Core RabbitMQ";
    var body = Encoding.UTF8.GetBytes(message);
    var properties = new BasicProperties();
    await channel.BasicPublishAsync("", "BasicTest", false, properties, body);
    Console.WriteLine(" [x] Sent {0}", message);
    Console.WriteLine(" Press [enter] to exit.");
    Console.ReadLine();
}
