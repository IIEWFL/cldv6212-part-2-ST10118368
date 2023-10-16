using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;

//Conection String
string conString = "DefaultEndpointsProtocol=https;AccountName=awehproduction;AccountKey=qypvKxtFnqAZdj0fPMmZnCLm4x3myCKjcPDhhwcYOAiZb5CTEE7qGJzbHhbjmoF88vyupPXBG9/0+AStnedSMw==;EndpointSuffix=core.windows.net";

//Queue creation
string queueName = "aweh-productions-queue";
QueueClient queueClient = new QueueClient(conString, queueName);

Console.WriteLine($"{queueName} is created.");
await queueClient.CreateIfNotExistsAsync();

//Insertion of Messages into Queue
Console.WriteLine($"\nInserting messages into {queueName}...");

//Message duo 1
await queueClient.SendMessageAsync("9910125015083:Waterfall Netcare:02/05/2023:P09987547649083");
await queueClient.SendMessageAsync("1245789630:03/06/2023:San Ridge Health Care:9910125015083");

//Message duo 2
await queueClient.SendMessageAsync("0101014815083:Botlalo Pharmacy:22/08/2023:J85967547649083");
await queueClient.SendMessageAsync("0243549630:30/09/2023:Botlalo Pharmacye:0101014815083");

//Message duo 3
await queueClient.SendMessageAsync("0501014816083:Ackermans Pharmacy:01/01/2023:P29875495791458");
await queueClient.SendMessageAsync("3575789630:27/02/2023:Lily Pharmacy:0501014816083");

//Message duo 4
await queueClient.SendMessageAsync("8505288055081:Lily Pharmacy:03/05/2023:J09987547646351");
await queueClient.SendMessageAsync("5985789630:15/06/2023:San Ridge Health Care:8505288055081");

//Message duo 5
await queueClient.SendMessageAsync("0005280015087:Waterfall Netcare:30/11/2023:J19987547648567");
await queueClient.SendMessageAsync("1025789630:31/12/2023:Ackermans Pharmacy:0005280015087");


Console.WriteLine("Complete....!");
