using SolidApiExample.Models;

namespace SolidApiExample.PaymentStrategies
{
    public class PagamentoBoleto : IPagamentoStrategy
    {
        public void ProcessarPagamento(Pedido pedido)
        {
            Console.WriteLine($"Pagamento do pedido: {pedido.Id} processado via Boleto Bancário!");
        }
    }
}
