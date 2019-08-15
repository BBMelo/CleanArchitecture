using System.Linq;
using vxTel.Domain.Entities;
using vxTel.Domain.Interfaces;
using vxTel.Repository.Context;

namespace vxTel.Repository.Repository
{
    public class TarifaLigacaoRepository : RepositoryBase<TarifaLigacao>, ITarifaLigacaoRepository
    {
        public TarifaLigacaoRepository(VxTelContext context) : base(context)
        {
        }

        public decimal ObterTarifaLigacao(int dddDestino, int dddOrigem)
        {
            return GetAll()
                   .Where(x => x.Destino.Code == dddDestino && x.Origem.Code == dddOrigem)
                   .DefaultIfEmpty(new TarifaLigacao())
                   .FirstOrDefault()
                   .TarifaPorMinuto;
        }
    }
}
