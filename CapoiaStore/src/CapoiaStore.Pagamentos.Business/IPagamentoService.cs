using Capoia.Core.DomainObjects.DTO;
using System.Threading.Tasks;

namespace CapoiaStore.Pagamentos.Business
{
    public interface IPagamentoService
    {
        Task<Transacao> RealizarPagamentoPedido(PagamentoPedido pagamentoPedido);
    }
}