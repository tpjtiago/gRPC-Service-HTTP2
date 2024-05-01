using Grpc.Net.Client;
using GrpcService1;

var channel = GrpcChannel.ForAddress("https://localhost:7012");

var client = new Greeter.GreeterClient(channel);
var req = new HelloRequest
{
    Name = "JOAO"
};

var reply = await client.SayHelloAsync(req);

Console.WriteLine("Saudacao: " + reply.Message);
Console.WriteLine("Pressione qualquer coisa para sair...");
Console.ReadKey();
