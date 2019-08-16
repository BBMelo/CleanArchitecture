using System;
using vxTel.Domain.Enumerators;
using vxTel.Domain.Interfaces;
using vxTel.Domain.Notifications;
using vxTel.UseCase.Interfaces;

namespace vxTel.UseCase.PlanoTelefoniaUseCase
{
    public class CalcularPrecoTarifaPorPlano : ICalcularPrecoTarifaPorPlano
    {        
        private readonly IPlanoTelefoniaRepository _planoTelefoniaRepository;
        private readonly Notification _notification;
        private readonly ITarifaLigacaoRepository _tarifaLigacaoRepository;
        
        public CalcularPrecoTarifaPorPlano(IPlanoTelefoniaRepository planoTelefoniaRepository,
                                         Notification notification, 
                                         ITarifaLigacaoRepository tarifaLigacaoRepository)
        {
            _planoTelefoniaRepository = planoTelefoniaRepository;
            _tarifaLigacaoRepository = tarifaLigacaoRepository;
            _notification = notification;            
        }   
        
        public decimal Execute(int dddOrigem, int dddDestino, int duracaoEmMinutos, EPlanoTelefonia planoSelecionado)
        {
            if (UseCaseValidator(dddOrigem, dddDestino, duracaoEmMinutos, planoSelecionado))
                return 0;            

            decimal tarifa = _tarifaLigacaoRepository.ObterTarifaLigacao(dddDestino,dddOrigem);                        

            var _plano = _planoTelefoniaRepository.ObterPlanoTelefonia(planoSelecionado);                        
                                   
            return _plano.MinutosPraFalarDeGraca == default(int)
            ? (tarifa * duracaoEmMinutos) 
            : ((duracaoEmMinutos > _plano.MinutosPraFalarDeGraca)
            ? ((tarifa * (duracaoEmMinutos - _plano.MinutosPraFalarDeGraca)) 
              + tarifa * (duracaoEmMinutos - _plano.MinutosPraFalarDeGraca) * _plano.AcrescimentoExcedente / 100)
            : default(decimal));            
        }  
        
        internal bool UseCaseValidator(int dddOrigem, int dddDestino, int duracaoEmMinutos, EPlanoTelefonia planoSelecionado)
        {
            if (dddOrigem == 0)
                _notification.AddNotification(Guid.NewGuid().ToString(),"Informe o DDD de Origem.");

            if (dddDestino == 0)
                _notification.AddNotification(Guid.NewGuid().ToString(),"Informe o DDD de destino.");

            if (duracaoEmMinutos == 0)
                _notification.AddNotification(Guid.NewGuid().ToString(),"Inform e o tempo de duração da ligação.");

            return _notification.HasNotifications;
        }
    }
}