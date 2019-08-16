using vxTel.Adapter.Application.ViewModel;

namespace vxTel.Adapter.Application.Interfaces
{
    public interface IPlanoTelefoniaApplication
    {
        FaleMaisViewModel CalcularLigacaoPorPlano(FaleMaisViewModel faleMaisViewModel);
        FaleMaisViewModel CompararPrecoEntrePlano(FaleMaisViewModel faleMaisViewModel);
    }
}