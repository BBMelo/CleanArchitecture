using vxTel.Adapter.Application.ViewModel;

namespace vxTel.Adapter.Application.Interfaces
{
    public interface IPlanoTelefoniaApplication
    {
        FaleMaisViewModel CalcularCustoDeUmaLigacao(FaleMaisViewModel faleMaisViewModel);
        FaleMaisViewModel CalcularCustoDeUmaLigacaoComPlanoFaleMais(FaleMaisViewModel faleMaisViewModel);
    }
}