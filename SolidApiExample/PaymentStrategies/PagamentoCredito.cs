using SolidApiExample.Models;

namespace SolidApiExample.PaymentStrategies
{
    public class PagamentoCredito : IPagamentoStrategy
    {
        public void ProcessarPagamento(Pedido pedido)
        {
            Console.WriteLine($"Pagamento do pedido: {pedido.Id} processado via Cartão de Crédito!");
        }
    }
}
