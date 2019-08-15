using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using vxTel.Domain.Entities;
using vxTel.Domain.Enumerators;

namespace vxTel.Domain.Interfaces
{
    public interface IPlanoTelefoniaRepository : IRepositoryBase<PlanoTelefonia>
    {
        PlanoTelefonia ObterPlanoTelefonia(EPlanoTelefonia planoTelefonia);
    }
}