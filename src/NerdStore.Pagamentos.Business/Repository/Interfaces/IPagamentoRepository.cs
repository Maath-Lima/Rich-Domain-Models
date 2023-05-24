using NerdStore.Core.Data.Interfaces;

namespace NerdStore.Pagamentos.Business.Repository.Interfaces
{
    public interface IPagamentoRepository : IRepository<Pagamento>
    {
        void Adicionar(Pagamento pagamento);

        void AdicionarTransacao(Transacao transacao);
    }
}