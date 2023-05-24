namespace NerdStore.Pagamentos.Business.Facades.Interfaces
{
    public interface IPagamentoCartaoCreditoFacade
    {
        Transacao RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}