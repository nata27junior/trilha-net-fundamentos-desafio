namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private readonly decimal precoInicial;
        private readonly decimal precoPorHora;
        private readonly List<string> veiculosEstacionados = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculosEstacionados.Add(placa.Trim().ToUpper());
                Console.WriteLine("Veículo cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            var placa = Console.ReadLine()?.Trim().ToUpper();

            // Verifica se o veículo existe
            if (veiculosEstacionados.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // TODO: Remover a placa digitada da lista de veículos
                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);
                    veiculosEstacionados.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido. Total a pagar: R$ {valorTotal:F2}");
                }
                else
                {
                    Console.WriteLine("Tempo inválido. Remoção cancelada.");

                }

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculosEstacionados.Count == 0)
            {
                Console.WriteLine("Não há veículos estacionados.");
                return;
            }
            else
            {
                // lista os veículos no estacionamento
                Console.WriteLine("Os veículos estacionados são:");
                veiculosEstacionados.ForEach(placa => Console.WriteLine($"- {placa}"));
            }
        }
    }
}