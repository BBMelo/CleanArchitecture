using vxTel.Domain.Bases;
using vxTel.Domain.Enumerators;
using vxTel.Domain.ValueObjects;

namespace vxTel.Domain.Entities
{
    public class PlanoTelefonia : EntityBase
    {        
        public DDD Origem { get; protected set; }        
        public DDD Destino { get; protected set; }
        public decimal PrecoPorMinuto { get; protected set; }
        public TipoPlanoTelefonia TipoPlano { get; protected set; }
    }
}