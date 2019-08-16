using System.Linq;
using vxTel.Adapter.Application.Interfaces;
using vxTel.Adapter.Application.ViewModel;
using vxTel.Domain.Enumerators;
using vxTel.UseCase.Interfaces;

namespace vxTel.Adapter.Application.Facade
{
    public sealed class PlanoTelefoniaFacade : IPlanoTelefoniaApplication
    {
        private readonly ICalcularPrecoTarifaPorPlano _calcularValorLigacao;
        private readonly ICompararPrecoEntrePlano _calcularTarifaLigacaoComPlanoESemPlano;

        public PlanoTelefoniaFacade(ICalcularPrecoTarifaPorPlano calcularValorLigacao,
                                    ICompararPrecoEntrePlano calcularTarifaLigacaoComPlanoESemPlano)
        {
            _calcularTarifaLigacaoComPlanoESemPlano = calcularTarifaLigacaoComPlanoESemPlano;
            _calcularValorLigacao = calcularValorLigacao;
        }

        public FaleMaisViewModel CalcularLigacaoPorPlano(FaleMaisViewModel faleMaisViewModel)
        {
            faleMaisViewModel
            .CustoSemPlano = string.Format("R$ {0}", _calcularValorLigacao
                                   .Execute(faleMaisViewModel.CodigoOrigem,
                                            faleMaisViewModel.CodigoDestino,
                                            faleMaisViewModel.TempoLigacao,
                                            (EPlanoTelefonia)faleMaisViewModel.PlanoFaleMais)
                                   .ToString("N2"));
            
            return faleMaisViewModel;
        }

        public FaleMaisViewModel CompararPrecoEntrePlano(FaleMaisViewModel faleMaisViewModel)
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
            {                
                faleMaisViewModel.CustoSemPlano = string.Format("R$ {0}", tarifas.First().ToString("N2"));
                faleMaisViewModel.CustoComPlano = string.Format("R$ {0}", tarifas.Last().ToString("N2"));
            }               

            return faleMaisViewModel;
        }
    }
}
