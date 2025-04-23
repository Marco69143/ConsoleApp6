
namespace LojaDeCamisas
{
    public class LojaDeCamisas
    {
        private List<Camisa> estoque = new List<Camisa>();

        // Método para adicionar uma camisa ao estoque
        public void AdicionarCamisa(Camisa camisa)
        {
            estoque.Add(camisa);
        }

        // Método para listar as camisas de um time específico
        public void ListarCamisasPorTime(string time)
        {
            var camisasDoTime = estoque.Where(c => c.Time.Equals(time, StringComparison.OrdinalIgnoreCase)).ToList();

            if (camisasDoTime.Count == 0)
            {
                Console.WriteLine($"Não há camisas do time {time} no estoque.");
            }
            else
            {
                Console.WriteLine($"Camisas do time {time}:");
                foreach (var camisa in camisasDoTime)
                {
                    camisa.ExibirInformacoes();
                }
            }
        }

        // Método para listar as camisas de um tamanho específico
        public void ListarCamisasPorTamanho(Tamanho tamanho)
        {
            var camisasDoTamanho = estoque.Where(c => c.Tamanho == tamanho).ToList();

            if (camisasDoTamanho.Count == 0)
            {
                Console.WriteLine($"Não há camisas no tamanho {tamanho} no estoque.");
            }
            else
            {
                Console.WriteLine($"Camisas no tamanho {tamanho}:");
                foreach (var camisa in camisasDoTamanho)
                {
                    camisa.ExibirInformacoes();
                }
            }
        }

        // Método para listar todas as camisas no estoque
        public void ListarTodasAsCamisas()
        {
            if (estoque.Count == 0)
            {
                Console.WriteLine("Não há camisas no estoque.");
            }
            else
            {
                Console.WriteLine("Camisas no estoque:");
                foreach (var camisa in estoque)
                {
                    camisa.ExibirInformacoes();
                }
            }
        }
        // Método para acessar a lista de camisas (necessário para a extensão)
        public List<Camisa> ObterCamisas()
        {
            return estoque;
        }

        // Método para remover uma camisa do estoque
        public void RemoverCamisa(Camisa camisa)
        {
            estoque.Remove(camisa);
        }

    }
}
    

