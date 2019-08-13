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
    }
}
