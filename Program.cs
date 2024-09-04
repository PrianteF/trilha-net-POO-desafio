using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando Nokia");
Smartphone nokia = new Nokia("1508-4657","Nokia 5G", "O que é este imei?",32)

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Testando Iphone");
Smartphone iphone = new Iphone("123-951-537","Iphone 15s", "Queria saber.",256)

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");