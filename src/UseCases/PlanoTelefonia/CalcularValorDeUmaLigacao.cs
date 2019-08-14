using System.Linq;
using vxTel.Adapter.Application.Contract.PlanoTelefonia;
using vxTel.Domain.Entities;
using vxTel.Domain.Enumerators;
using vxTel.Domain.Interfaces;

namespace vxTel.UseCase.PlanoTelefoniaUseCase
{
    public class CalcularValorDeUmaLigacao : ICalcularValorLigacao
    {        
        private readonly IPlanoTelefoniaRepository _repository;
        private readonly INotification _notification;
        private readonly ITarifaLigacaoRepository _tarifaLigacaoRepository;
        public CalcularValorDeUmaLigacao(IPlanoTelefoniaRepository repository, 
                                         INotification notification, 
                                         ITarifaLigacaoRepository tarifaLigacaoRepository)
        {
            _repository = repository;
            _notification = notification;
            _tarifaLigacaoRepository = tarifaLigacaoRepository;
        }   
        
        public decimal Execute(int destino, int origem, int minuto, EPlanoTelefonia plano)
        {            
            var tarifa = _tarifaLigacaoRepository
                         .GetAll()
                         .Where(x => x.Destino.Code == destino && x.Origem.Code == origem)
                         .DefaultIfEmpty(new TarifaLigacao())
                         .FirstOrDefault()
                         .TarifaPorMinuto;

            var planoTelefonia = _repository
                                   .GetAll()
                                   .Where(x => x.EPlanoTelefonia == plano)
                                   .DefaultIfEmpty(new PlanoTelefonia())
                                   .DefaultIfEmpty()
                                   .FirstOrDefault();
                                   
            return planoTelefonia.MinutosPraFalarDeGraca == default(int)
                                                     ? (tarifa * minuto) 
                                                     : ((minuto > planoTelefonia.MinutosPraFalarDeGraca)
                                                     ? ((tarifa * (minuto - planoTelefonia.MinutosPraFalarDeGraca)) 
                                                     + tarifa * (minuto - planoTelefonia.MinutosPraFalarDeGraca) * 10 / 100)
                                                     : 0);            
        }       
    }
}