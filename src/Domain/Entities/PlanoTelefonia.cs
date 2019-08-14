using System;
using System.Collections.Generic;
using System.Text;
using vxTel.Domain.Bases;
using vxTel.Domain.Enumerators;
using vxTel.Domain.ValueObjects;

namespace vxTel.Domain.Entities
{
    public class PlanoTelefonia : EntityBase
    {
        public EPlanoTelefonia EPlanoTelefonia { get; protected set; }
        public int MinutosPraFalarDeGraca { get; protected set; }
        public decimal AcrescimentoExcedente { get; protected set; }       
    }
}
