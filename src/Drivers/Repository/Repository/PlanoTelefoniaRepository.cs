using vxTel.Domain.Entities;
using vxTel.Domain.Interfaces;
using vxTel.Repository.Context;

namespace vxTel.Repository.Repository
{
    public class PlanoTelefoniaRepository : RepositoryBase<PlanoTelefonia>, IPlanoTelefoniaRepository
    {
        public PlanoTelefoniaRepository(VxTelContext context) : base(context)
        {

        }
    }
}