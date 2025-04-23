

namespace LojaDeCamisas
{
    // Enum para definir os tamanhos das camisas
    public enum Tamanho
    {
        PP,
        P,
        M,
        G,
        GG
    }

    // Classe que representa uma camisa
    public class Camisa
    {
        public string Time { get; private set; }
        public Tamanho Tamanho { get; private set; }
        public double Preco { get; private set; }

     

        // Construior da camisa
        public Camisa(string time, Tamanho tamanho, double preco)
        {
            Time = time;
            Tamanho = tamanho;
            Preco = preco;
        }

        // Método para exibir informações sobre a camisa
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Camisa do time {Time}, Tamanho {Tamanho}, Preço: R${Preco:F2}");
        }
    }
}