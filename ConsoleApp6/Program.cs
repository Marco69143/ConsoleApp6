
namespace LojaDeCamisas
{
    class Program
    {
        static void Main(string[] args)

        {
            // Criando a loja de camisas
            LojaDeCamisas loja = new LojaDeCamisas();

            // Adicionando algumas camisas ao estoque
            loja.AdicionarCamisa(new Camisa("Flamengo", Tamanho.M, 129.99));
            loja.AdicionarCamisa(new Camisa("Vasco", Tamanho.G, 99.99));
            loja.AdicionarCamisa(new Camisa("Fluminense", Tamanho.P, 109.5));
            loja.AdicionarCamisa(new Camisa("Palmeiras", Tamanho.GG, 150.00));
            loja.AdicionarCamisa(new Camisa("Botafogo", Tamanho.PP, 119.75));
            loja.AdicionarCamisa(new Camisa("Internacional", Tamanho.GG, 120.00));
            loja.AdicionarCamisa(new Camisa("Gremio", Tamanho.G, 100.00));
            loja.AdicionarCamisa(new Camisa("Tricolor paulista", Tamanho.GG, 2.00));
            loja.AdicionarCamisa(new Camisa("Mirassol", Tamanho.P, 90.00));
            loja.AdicionarCamisa(new Camisa("Corinthias", Tamanho.PP, 0.01));
            loja.AdicionarCamisa(new Camisa("Paysandu", Tamanho.GG, 9000.00));





            // Interação com o usuário
            bool executar = true;
            while (executar)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Listar todas as camisas");
                Console.WriteLine("2. Listar camisas por time");
                Console.WriteLine("3. Listar camisas por tamanho");
                Console.WriteLine("4. Vender uma camisa");
                Console.WriteLine("5. Comprar (adicionar) uma nova camisa");
                Console.WriteLine("6. Sair");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        loja.ListarTodasAsCamisas();
                        break;
                    case "2":
                        Console.Write("Digite o nome do time: ");
                        string time = Console.ReadLine();
                        loja.ListarCamisasPorTime(time);
                        break;
                    case "3":
                        Console.WriteLine("Escolha o tamanho da camisa (PP, P, M, G, GG):");
                        string tamanhoInput = Console.ReadLine();
                        if (Enum.TryParse(tamanhoInput, true, out Tamanho tamanho))
                        {
                            loja.ListarCamisasPorTamanho(tamanho);
                        }
                        else
                        {
                            Console.WriteLine("Tamanho inválido.");
                        }
                        break;
                    case "4":
                        Console.Write("Digite o nome do time da camisa que deseja vender: ");
                        string timeVenda = Console.ReadLine();
                        Console.Write("Digite o tamanho da camisa (PP, P, M, G, GG): ");
                        string tamanhoVendaInput = Console.ReadLine();
                        if (Enum.TryParse(tamanhoVendaInput, true, out Tamanho tamanhoVenda))
                        {
                            loja.VenderCamisa(timeVenda, tamanhoVenda);
                        }
                        else
                        {
                            Console.WriteLine("Tamanho inválido.");
                        }
                        break;
                    case "5":
                        Console.Write("Digite o nome do time da nova camisa: ");
                        string timeNova = Console.ReadLine();

                        Console.Write("Digite o tamanho da nova camisa (PP, P, M, G, GG): ");
                        string tamanhoNovaInput = Console.ReadLine();

                        if (!Enum.TryParse(tamanhoNovaInput, true, out Tamanho tamanhoNova))
                        {
                            Console.WriteLine("Tamanho inválido.");
                            break;
                        }

                        Console.Write("Digite o preço da camisa (ex: 149.99): ");
                        string precoInput = Console.ReadLine();

                        if (!double.TryParse(precoInput, out double precoNova) || precoNova < 0)
                        {
                            Console.WriteLine("Preço inválido.");
                            break;
                        }

                        Camisa novaCamisa = new Camisa(timeNova, tamanhoNova, precoNova);
                        loja.AdicionarCamisa(novaCamisa);

                        Console.WriteLine($"\n✅ Camisa do {timeNova} adicionada ao estoque com sucesso!");
                        break;
                    case "6":
                        executar = false;
                        break;

                }
            }
        }
    }
} 
