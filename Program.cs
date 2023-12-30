using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine(" Smartphone Nokia: ");
Smartphone nokia  = new Nokia("81 973454619", "Nokia C2 2ND Edition","75412365897452147",128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("-------------------------------------------------------------------------");

Console.WriteLine(" Smatphone Iphone: ");
Smartphone iphone = new Iphone("81 973454619", "IPHONE 15PRO MAX SILVER","785452197452147",256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");