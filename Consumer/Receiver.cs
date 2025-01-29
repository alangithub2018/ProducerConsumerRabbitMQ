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

    var consumer = new RabbitMQ.Client.Events.AsyncEventingBasicConsumer(channel);
    consumer.ReceivedAsync += async (model, ea) =>
    {
        var body = ea.Body.ToArray();
        var message = Encoding.UTF8.GetString(body);
        Console.WriteLine(" [x] Received {0}", message);
        await Task.CompletedTask;
    };
    await channel.BasicConsumeAsync(queue: "BasicTest", autoAck: true, consumer: consumer);
    Console.WriteLine(" Press [enter] to exit.");
    Console.ReadLine();
}