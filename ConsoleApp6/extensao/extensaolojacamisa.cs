using System;
using System.Linq;

namespace LojaDeCamisas
{
    public static class LojaDeCamisasExtensions
    {
        // Método de extensão para vender (remover) uma camisa do estoque
        public static void VenderCamisa(this LojaDeCamisas loja, string time, Tamanho tamanho)
        {
            var camisaParaVender = loja.ObterCamisas()
                .FirstOrDefault(c => c.Time.Equals(time, StringComparison.OrdinalIgnoreCase)
                                  && c.Tamanho == tamanho);

            if (camisaParaVender != null)
            {
                loja.RemoverCamisa(camisaParaVender);
                Console.WriteLine($"\n Venda realizada: {time} - Tamanho {tamanho} por R${camisaParaVender.Preco:F2}");
            }
            else
            {
                Console.WriteLine($"\n Camisa do time {time} com tamanho {tamanho} não encontrada no estoque.");
            }
        }
    }
}