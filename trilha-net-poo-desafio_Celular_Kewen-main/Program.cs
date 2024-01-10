using System.Globalization;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\n");

Console.WriteLine("Celular Nokia:");

Smartphone nokia = new Nokia(numero: "81999999999", modelo: "Dragão Voador", imei: "11123356588869855", memoria: 32);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Duolingo");
nokia.MostrarInformacoesAparelho();

Console.WriteLine("\n");

Console.WriteLine("Celular iPhone");

Smartphone iphone = new Iphone(numero: "81996699669", modelo: "Universo Cósmico", imei: "68974563211323464", memoria: 16);
iphone.Ligar();
iphone.InstalarAplicativo("Mimo");
iphone.MostrarInformacoesAparelho();