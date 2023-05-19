using NerdStore.Core.DomainObjects.DTOs;

namespace NerdStore.Catalogo.Domain.Services.Interfaces
{
    public interface IEstoqueService : IDisposable
    {
        Task<bool> DebitarEstoque(Guid produtoId, int quantidade);

        Task<bool> DebitarListaProdutosPedido(ListaProdutosPedido lista);

        Task<bool> ReporEstoque(Guid produtoId, int quantidade);

        Task<bool> ReporListaProdutosPedido(ListaProdutosPedido lista);
    }
}
