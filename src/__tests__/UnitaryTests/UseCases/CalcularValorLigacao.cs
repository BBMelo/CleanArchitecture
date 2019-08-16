using TechTalk.SpecFlow;
using vxTel.Domain.Enumerators;
using vxTel.Domain.Interfaces;
using vxTel.Domain.Notifications;
using vxTel.Repository.Context;
using vxTel.Repository.Repository;
using vxTel.UseCase.Interfaces;
using vxTel.UseCase.PlanoTelefoniaUseCase;
using Xunit;

namespace vxTel.Unit.Test.UseCases
{
    [Binding]
    public class CalcularValorLigacao
    {
        private ICalcularPrecoTarifaPorPlano _calcularValorLigacao;
        private IPlanoTelefoniaRepository _planoTelefoniaRepository;
        private ITarifaLigacaoRepository _tarifaLigacaoRepository;
        private Notification _notification;
        private decimal resultado { get; set; }

        public CalcularValorLigacao()
        {
            _tarifaLigacaoRepository = new TarifaLigacaoRepository(new VxTelContext());
            _planoTelefoniaRepository = new PlanoTelefoniaRepository(new VxTelContext());
            _notification = new Notification();
            _calcularValorLigacao = new CalcularPrecoTarifaPorPlano(_planoTelefoniaRepository, _notification, _tarifaLigacaoRepository);
        }
        
        [Given(@"Quando eu informar corretamente os dados de origem\|destino\|duracao\|plano (.*)\|(.*)\|(.*)\|(.*)")]
        public void DadoQuandoEuInformarCorretamenteOsDadosDeOrigemDestinoDuracaoPlano(int dddOrigem, int dddDestino, int duracaoEmMinutos, int planoSelecionado)
        {
            resultado = _calcularValorLigacao.Execute(dddOrigem, dddDestino, duracaoEmMinutos, (EPlanoTelefonia)planoSelecionado);            
        }
        
        [Then(@"O resultado do calculo deve ser (.*)")]
        public void EntaoOResultadoDoCalculoDeveSer_(string valorDaLigacao)
        {            
            Assert.Equal(valorDaLigacao, resultado.ToString("N2"));
        }
    }
}