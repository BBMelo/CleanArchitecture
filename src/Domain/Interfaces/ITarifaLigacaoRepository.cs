using vxTel.Domain.Entities;

namespace vxTel.Domain.Interfaces
{
    public interface ITarifaLigacaoRepository : IRepositoryBase<TarifaLigacao>
    {
        decimal ObterTarifaLigacao(int dddDestino, int dddOrigem);
    }
}
