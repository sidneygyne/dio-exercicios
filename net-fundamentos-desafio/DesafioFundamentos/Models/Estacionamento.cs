namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // OK REALIZADO

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"Veículo com placa nº {placa} já esta no estacionamento! Verifique a placa e tente novamente!");
            }

            else 
            {
                veiculos.Add(placa);
                Console.WriteLine($"Inclusao da placa nº {placa} realizada com sucesso!");
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // OK REALIZADO
            string placa = Console.ReadLine();


            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // OK REALIZADO
                decimal valorTotal = 0;
                string horas = Console.ReadLine();
                int.TryParse(horas, out int horasConvertida);
                valorTotal = precoInicial + (precoPorHora * horasConvertida);

                // TODO: Remover a placa digitada da lista de veículos
                // OK REALIZADO
                string placaRemovida = placa;
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo placa nº {placaRemovida} foi removido e o preço total foi de: R$ {valorTotal}.");


            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // OK REALIZADO
                int contadorArray = 1;
                foreach (string item in veiculos)
                {
                    Console.WriteLine($"{contadorArray} . {item}");
                    contadorArray++;
                }
                Console.WriteLine($"Quantidade total de veiculos estacionados: {contadorArray - 1}.");

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
