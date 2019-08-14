using vxTel.Domain.Bases;
using vxTel.Domain.ValueObjects;

namespace vxTel.Domain.Entities
{
    public class TarifaLigacao : EntityBase
    {               
        public DDD Origem { get; protected set; }
        public DDD Destino { get; protected set; }
        public decimal TarifaPorMinuto { get; protected set; }                     
    }
}