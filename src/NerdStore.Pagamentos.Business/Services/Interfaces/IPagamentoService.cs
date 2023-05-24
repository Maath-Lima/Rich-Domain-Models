using NerdStore.Core.DomainObjects.DTOs;

namespace NerdStore.Pagamentos.Business.Services.Interfaces
{
    public interface IPagamentoService
    {
        Task<Transacao> RealizarPagamentoPedido(PagamentoPedido pagamentoPedido);
    }
}