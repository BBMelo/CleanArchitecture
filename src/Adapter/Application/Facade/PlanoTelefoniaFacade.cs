using System.Linq;
using vxTel.Adapter.Application.Interfaces;
using vxTel.Adapter.Application.ViewModel;
using vxTel.Domain.Enumerators;
using vxTel.UseCase.Interfaces;

namespace vxTel.Adapter.Application.Facade
{
    public sealed class PlanoTelefoniaFacade : IPlanoTelefoniaApplication
    {
        private readonly ICalcularValorLigacao _calcularValorLigacao;
        private readonly ICalcularTarifaLigacaoComPlanoESemPlano _calcularTarifaLigacaoComPlanoESemPlano;

        public PlanoTelefoniaFacade(ICalcularValorLigacao calcularValorLigacao,
                                    ICalcularTarifaLigacaoComPlanoESemPlano calcularTarifaLigacaoComPlanoESemPlano)
        {
            _calcularTarifaLigacaoComPlanoESemPlano = calcularTarifaLigacaoComPlanoESemPlano;
            _calcularValorLigacao = calcularValorLigacao;
        }

        public FaleMaisViewModel CalcularCustoDeUmaLigacao(FaleMaisViewModel faleMaisViewModel)
        {
            faleMaisViewModel
            .CustoSemPlano = string.Format("R$ {0}", _calcularValorLigacao
                                   .Execute(faleMaisViewModel.CodigoOrigem,
                                            faleMaisViewModel.CodigoDestino,
                                            faleMaisViewModel.TempoLigacao,
                                            EPlanoTelefonia.PlanoPadrao)
                                   .ToString("N2"));
            
            return faleMaisViewModel;
        }

        public FaleMaisViewModel CalcularCustoDeUmaLigacaoComPlanoFaleMais(FaleMaisViewModel faleMaisViewModel)
        {
            var tarifas  =  _calcularTarifaLigacaoComPlanoESemPlano
                            .Execute(faleMaisViewModel.CodigoOrigem,
                                     faleMaisViewModel.CodigoDestino,
                                     faleMaisViewModel.TempoLigacao,
                                     (EPlanoTelefonia)faleMaisViewModel.PlanoFaleMais);

            if (tarifas == null || !tarifas.Any())
                faleMaisViewModel.CustoComPlano =
                faleMaisViewModel.CustoSemPlano =
                string.Format("R$ 0,00");
            else
                faleMaisViewModel.CustoComPlano = string.Format("R$ {0}",tarifas.FirstOrDefault().ToString("N2"));
                faleMaisViewModel.CustoSemPlano = string.Format("R$ 0,00");

            return faleMaisViewModel;
        }
    }
}
