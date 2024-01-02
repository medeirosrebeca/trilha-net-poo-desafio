using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Chama o construtor da classe base
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Nokia.");
        }
    }
}
