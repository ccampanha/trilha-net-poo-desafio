using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Console.WriteLine("Instanciando um smartphone Nokia...");
Smartphone nokia = new Nokia(numero: "21999923578", modelo: "Modelo Bom", imei: "111111124", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();    
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Console.WriteLine("Instanciando um smartphone iPhone...");
Smartphone iphone = new Iphone(numero: "11981731242", modelo: "Modelo Caro", imei: "111111222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
  