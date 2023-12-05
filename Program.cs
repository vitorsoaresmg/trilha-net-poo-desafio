using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "(77) 987654321", modelo: 15600, imei: 78787878, memoria: 30);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine($"Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "(88) 123456789", modelo: 26700, imei: 65656565, memoria: 60);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
nokia.ReceberLigacao();
