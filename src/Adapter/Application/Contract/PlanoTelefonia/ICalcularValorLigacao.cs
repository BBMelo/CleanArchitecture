using vxTel.Domain.Enumerators;

namespace vxTel.Adapter.Application.Contract.PlanoTelefonia
{
    public interface ICalcularValorLigacao
    {
        decimal Execute(int dddOrigem, int dddDestino, int duracaoEmMinutos, EPlanoTelefonia planoSelecionado);
    }
}
