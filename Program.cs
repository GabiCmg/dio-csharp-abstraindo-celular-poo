using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "1195252-7292", modelo: "Iphone 15 Pro Max", imei: "123456", memoria: 13);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1194575-8255", modelo: "Nokia X30", imei: "654321", memoria: 3);
nokia.Ligar();
nokia.InstalarAplicativo("Snake Game");