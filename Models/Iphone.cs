using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Chama o construtor da classe base
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na App Store do iPhone.");
        }
    }
}
