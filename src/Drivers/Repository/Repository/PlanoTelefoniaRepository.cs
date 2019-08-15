using System.Linq;
using vxTel.Domain.Entities;
using vxTel.Domain.Enumerators;
using vxTel.Domain.Interfaces;
using vxTel.Repository.Context;

namespace vxTel.Repository.Repository
{
    public class PlanoTelefoniaRepository : RepositoryBase<PlanoTelefonia>, IPlanoTelefoniaRepository
    {
        public PlanoTelefoniaRepository(VxTelContext context) : base(context)
        {

        }       

        public PlanoTelefonia ObterPlanoTelefonia(EPlanoTelefonia planoTelefonia)
        {
            return GetAll()
                  .Where(x => x.EPlanoTelefonia == planoTelefonia)
                  .DefaultIfEmpty(new PlanoTelefonia())
                  .FirstOrDefault();          
        }
    }
}