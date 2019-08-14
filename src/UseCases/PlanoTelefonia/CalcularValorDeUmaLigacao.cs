using System.Linq;
using vxTel.Adapter.Application.Contract.PlanoTelefonia;
using vxTel.Domain.Entities;
using vxTel.Domain.Enumerators;
using vxTel.Domain.Interfaces;

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
            var tarifa = _tarifaLigacaoRepository
                         .GetAll()
                         .Where(x => x.Destino.Code == dddDestino && x.Origem.Code == dddOrigem)
                         .DefaultIfEmpty(new TarifaLigacao())
                         .FirstOrDefault()
                         .TarifaPorMinuto;

            var _plano = _planoTelefoniaRepository
                         .GetAll()
                         .Where(x => x.EPlanoTelefonia == planoSelecionado)
                         .DefaultIfEmpty(new PlanoTelefonia())
                         .DefaultIfEmpty()
                         .FirstOrDefault();
                                   
            return _plano.MinutosPraFalarDeGraca == default(int)
            ? (tarifa * duracaoEmMinutos) 
            : ((duracaoEmMinutos > _plano.MinutosPraFalarDeGraca)
            ? ((tarifa * (duracaoEmMinutos - _plano.MinutosPraFalarDeGraca)) 
              + tarifa * (duracaoEmMinutos - _plano.MinutosPraFalarDeGraca) * _plano.AcrescimentoExcedente / 100)
            : default(decimal));            
        }       
    }
}