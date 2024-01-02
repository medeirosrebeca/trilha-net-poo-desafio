using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
using System;

class Program
{
    static void Main()
    {
        // Criando instâncias dos smartphones
        Iphone iphone = new Iphone("945938450", "iPhone SE", "IMEI8453", 64);
        Nokia nokia = new Nokia("981093842", "Nokia 6", "IMEI9310", 64);

        // Testando os métodos
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");

        Console.ReadLine();
    }
}