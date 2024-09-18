namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // OK REALIZADO
    public class Iphone : Smartphone
    {
         public Iphone(string nome, string modelo, string imei, int memoria) : base(nome, modelo, imei, memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // OK REALIZADO
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone...");
        }
    }
}