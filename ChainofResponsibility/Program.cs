// See https://aka.ms/new-console-template for more information
using ChainofResponsibility;

Console.WriteLine("Hello, World!");

ISupportHandler level1 = new Level1SupportHandler();
ISupportHandler level2 = new Level2Handler();
ISupportHandler level3 = new Level3SupportHandler();

level1.SetNextHandler(level2);
level2.SetNextHandler(level3);

Request request1 = new Request(Priority.BASIC);
Request request2 = new Request(Priority.INTERMEDIATE);
Request request3 = new Request(Priority.CRITICAL);

level1.handleReques(request1);
level1.handleReques(request2);
level1.handleReques(request3);

Console.ReadLine();
