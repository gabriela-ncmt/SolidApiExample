using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidApiExample.Models;
using SolidApiExample.PaymentStrategies;
using SolidApiExample.Services;

namespace SolidApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly PedidoService _service;

        public PedidosController(PedidoService pedidoService)
        {
            _service = pedidoService;
        }

        [HttpPost]
        public IActionResult CriarPedido([FromBody] Pedido pedido)
        {
            IPagamentoStrategy pagamentoStrategy = pedido.FormaPagamento.ToLower() switch
            {
                "credito" => new PagamentoCredito(),
                "boleto" => new PagamentoBoleto(),
                _ => throw new ArgumentException("Forma de pagamento inválida")
            };

            PedidoService pedidoService = new PedidoService(pagamentoStrategy);
            pedidoService.CriarPedido(pedido);

            return Ok($"Pedido: {pedido.Id} criado com sucesso!");
        }
    }
}
