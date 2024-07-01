Client c1 = new();
Client c2 = new();

FindFiles ff1 = new("..\\..\\..\\obj", "json");
FindFiles ff2 = new(".","json");

ff1.Done += (obj) => Console.WriteLine($"ff1 Каталог {ff1.Dir} найден!!!");
ff2.Done += (obj) => Console.WriteLine($"ff2 Каталог {ff2.Dir} найден!!!");
FindFiles.StaticDone += (obj) => Console.WriteLine($"STATIC Каталог {((FindFiles)obj).Dir} найден!!!");

ff1.Find();
ff2.Find();

Console.WriteLine("end");

