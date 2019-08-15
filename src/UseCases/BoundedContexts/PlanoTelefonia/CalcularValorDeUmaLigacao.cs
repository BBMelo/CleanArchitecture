using vxTel.Domain.Enumerators;
using vxTel.Domain.Interfaces;
using vxTel.UseCase.Interfaces;

namespace vxTel.UseCase.PlanoTelefoniaUseCase
{
    public class CalcularValorDeUmaLigacao : ICalcularValorLigacao
    {        
        private readonly IPlanoTelefoniaRepository _planoTelefoniaRepository;
        private readonly INotification _notification;
        private readonly ITarifaLigacaoRepository _tarifaLigacaoRepository;
        
        public CalcularValorDeUmaLigacao(IPlanoTelefoniaRepository planoTelefoniaRepository, 
                                         INotification notification, 
                                         ITarifaLigacaoRepository tarifaLigacaoRepository)
        {
            _planoTelefoniaRepository = planoTelefoniaRepository;
            _tarifaLigacaoRepository = tarifaLigacaoRepository;
            _notification = notification;            
        }   
        
        public decimal Execute(int dddOrigem, int dddDestino, int duracaoEmMinutos, EPlanoTelefonia planoSelecionado)
        {
            decimal tarifa = _tarifaLigacaoRepository.ObterTarifaLigacao(dddDestino,dddOrigem);                        

            var _plano = _planoTelefoniaRepository.ObterPlanoTelefonia(planoSelecionado);                        
                                   
            return _plano.MinutosPraFalarDeGraca == default(int)
            ? (tarifa * duracaoEmMinutos) 
            : ((duracaoEmMinutos > _plano.MinutosPraFalarDeGraca)
            ? ((tarifa * (duracaoEmMinutos - _plano.MinutosPraFalarDeGraca)) 
              + tarifa * (duracaoEmMinutos - _plano.MinutosPraFalarDeGraca) * _plano.AcrescimentoExcedente / 100)
            : default(decimal));            
        }       
    }
}