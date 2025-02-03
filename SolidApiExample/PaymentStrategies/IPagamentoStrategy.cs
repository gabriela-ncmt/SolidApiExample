using SolidApiExample.Models;

namespace SolidApiExample.PaymentStrategies
{
    public interface IPagamentoStrategy
    {
        void ProcessarPagamento(Pedido pedido);
    }
}
