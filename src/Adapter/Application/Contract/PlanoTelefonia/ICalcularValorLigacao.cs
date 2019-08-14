using vxTel.Domain.Enumerators;

namespace vxTel.Adapter.Application.Contract.PlanoTelefonia
{
    public interface ICalcularValorLigacao
    {
        decimal Execute(int destino, int origem, int minuto, EPlanoTelefonia plano);
    }
}
