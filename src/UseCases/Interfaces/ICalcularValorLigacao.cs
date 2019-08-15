using vxTel.Domain.Enumerators;

namespace vxTel.UseCase.Interfaces
{
    public interface ICalcularValorLigacao
    {
        decimal Execute(int dddOrigem, int dddDestino, int duracaoEmMinutos, EPlanoTelefonia planoSelecionado);
    }
}
