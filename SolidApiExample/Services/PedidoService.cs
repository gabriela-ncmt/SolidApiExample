using SolidApiExample.Models;
using SolidApiExample.PaymentStrategies;

namespace SolidApiExample.Services
{
    public class PedidoService
    {
        private readonly IPagamentoStrategy _pagamentoStrategy;

        public PedidoService(IPagamentoStrategy pagamentoStrategy)
        {
            _pagamentoStrategy = pagamentoStrategy;
        }

        private void CriarPedido(Pedido pedido)
        {
            Console.WriteLine($"Pedido {pedido.Id} de R${pedido.Valor} criado com sucesso!");
            _pagamentoStrategy.ProcessarPagamento(pedido);
        }
    }
}
