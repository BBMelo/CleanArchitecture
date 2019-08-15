using vxTel.Adapter.Application.Facade;
using vxTel.Adapter.Application.Interfaces;
using vxTel.Adapter.Application.ViewModel;
using vxTel.Domain.Interfaces;
using vxTel.Domain.Notifications;
using vxTel.Repository.Context;
using vxTel.Repository.Repository;
using vxTel.UseCase.BoundedContexts.PlanoTelefonia;
using vxTel.UseCase.Interfaces;
using vxTel.UseCase.PlanoTelefoniaUseCase;
using Xunit;

namespace vxTel.Unit.Test.ApplicationAdapters
{
    public class PlanoTelefoniaApplicationTeste
    {
        private IPlanoTelefoniaApplication _planoTelefoniaApplication;
        private ICalcularTarifaLigacaoComPlanoESemPlano _calcularTarifaLigacaoComPlanoESemPlano;
        private ICalcularValorLigacao _calcularValorLigacao;
        private IPlanoTelefoniaRepository _planoTelefoniaRepository;
        private ITarifaLigacaoRepository _tarifaLigacaoRepository;
        private INotification _notification;

        public PlanoTelefoniaApplicationTeste()
        {            
            _tarifaLigacaoRepository = new TarifaLigacaoRepository(new VxTelContext());
            _planoTelefoniaRepository = new PlanoTelefoniaRepository(new VxTelContext());
            _notification = new Notification();
            _calcularValorLigacao = new CalcularValorDeUmaLigacao(_planoTelefoniaRepository, _notification, _tarifaLigacaoRepository);
            _calcularTarifaLigacaoComPlanoESemPlano = new CalcularTarifaLigacaoComPlanoESemPlano(_calcularValorLigacao);
            _planoTelefoniaApplication = new PlanoTelefoniaFacade(_calcularValorLigacao, _calcularTarifaLigacaoComPlanoESemPlano);
        }
                
        [Theory(DisplayName = "Deve-se obter sucesso quando eu for calcular a tarifa de uma ligação sem usar nenhum plano FaleMais")]
        [InlineData(11, 16, 20,  "R$ 38,00" )]
        [InlineData(11, 17, 80,  "R$ 136,00")]
        [InlineData(18, 11, 200, "R$ 380,00")]
        [InlineData(18, 17, 100, "R$ 0,00"  )]
        public void CalcularTarifaDeUmaLigacaoSemPlanoFaleMais(int origem, int destino, int duracao, string resultado)
        {
            //Given
            var faleMaisViewModel = new FaleMaisViewModel
            {
                CodigoDestino = destino,
                CodigoOrigem = origem,
                TempoLigacao = duracao,                
            };

            //When
            _planoTelefoniaApplication.CalcularCustoDeUmaLigacao(faleMaisViewModel);

            //Then
            Assert.Equal(resultado, faleMaisViewModel.CustoSemPlano);
        }

        [Theory(DisplayName = "Deve-se obter sucesso quando eu for calcular a tarifa de uma ligação usando algum plano FaleMais")]
        [InlineData(11, 16, 20, "FaleMais30","R$ 0,00")]
        [InlineData(11, 17, 80, "FaleMais60","R$ 37,40")]
        [InlineData(18, 11, 200,"FaleMais120","R$ 167,20")]
        [InlineData(18, 17, 100,"FaleMais30","R$ 0,00")]
        public void CalcularTarifaDeUmaLigacaoComPlanoFaleMais(int origem, int destino, int duracao, string plano, string resultado)
        {
            //Given
            int _plano;

            switch (plano)
            {
                case "FaleMais30":
                    _plano = 1;
                    break;
                case "FaleMais60":
                    _plano = 2;
                    break;
                case "FaleMais120":
                    _plano = 3;
                    break;
                default:
                    _plano = 0;
                    break;
            }

            var faleMaisViewModel = new FaleMaisViewModel
            {
                CodigoDestino = destino,
                CodigoOrigem = origem,
                TempoLigacao = duracao,
                PlanoFaleMais = _plano
            };

            //When
            _planoTelefoniaApplication.CalcularCustoDeUmaLigacao(faleMaisViewModel);

            //Then
            Assert.Equal(resultado, faleMaisViewModel.CustoSemPlano);
        }

        [Theory(DisplayName = "Deve-se obter sucesso quando eu for calcular a tarifa de uma ligação com plano FaleMais ")]
        [InlineData(11, 16, 20, "FaleMais30",   "R$ 0,00"   ,"R$ 38,00" )]
        [InlineData(11, 17, 80, "FaleMais60",   "R$ 37,40"  ,"R$ 136,00")]
        [InlineData(18, 11, 200, "FaleMais120", "R$ 167,20" ,"R$ 380,00")]
        [InlineData(18, 17, 100, "FaleMais30",  "R$ 0,00"   , "R$ 0,00")]
        public void CalcularTarifaLigacao(int origem, int destino, int duracao, string plano, string resultadoComPlano, string resultadoSemPlano)
        {
            //Given
            int _plano;

            switch (plano)
            {
                case "FaleMais30":
                    _plano = 1;
                    break;
                case "FaleMais60":
                    _plano = 2;
                    break;
                case "FaleMais120":
                    _plano = 3;
                    break;
                default:
                    _plano = 0;
                    break;
            }

            var faleMaisViewModel = new FaleMaisViewModel
            {
                CodigoDestino = destino,
                CodigoOrigem = origem,
                TempoLigacao = duracao,
                PlanoFaleMais = _plano
            };

            //When
            _planoTelefoniaApplication.CalcularCustoDeUmaLigacaoComPlanoFaleMais(faleMaisViewModel);

            //Then
            Assert.Equal(resultadoComPlano, faleMaisViewModel.CustoComPlano);
            Assert.Equal(resultadoSemPlano, faleMaisViewModel.CustoSemPlano);
        }
    }
}
