

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // OK REALIZADO
    public class Nokia : Smartphone
    {
        public Nokia(string nome, string modelo, string imei, int memoria) : base(nome, modelo, imei, memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // OK REALIZADO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
        }
    }
}