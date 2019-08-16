using System.Collections.Generic;
using vxTel.Domain.Enumerators;

namespace vxTel.UseCase.Interfaces
{
    public interface ICompararPrecoEntrePlano
    {
        List<decimal> Execute(int dddOrigem, int dddDestino, int duracaoEmMinutos, EPlanoTelefonia planoSelecionado);
    }
}
