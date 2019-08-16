using vxTel.Domain.Enumerators;

namespace vxTel.UseCase.Interfaces
{
    public interface ICalcularPrecoTarifaPorPlano
    {
        decimal Execute(int dddOrigem, int dddDestino, int duracaoEmMinutos, EPlanoTelefonia planoSelecionado);
    }
}