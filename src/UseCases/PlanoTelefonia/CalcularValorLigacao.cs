using System;
using System.Linq;
using vxTel.Domain.Enumerators;
using vxTel.Domain.Interfaces;
using vxTel.Domain.ValueObjects;

namespace vxTel.UseCase.PlanoTelefonia
{
    public class CalcularValorLigacao : IRequestHandler<DDD, DDD, int, EPlanoTelefonia , decimal>
    {
        private readonly IPlanoTelefoniaRepository _repository;
        private readonly INotification _notification;

        public CalcularValorLigacao(IPlanoTelefoniaRepository repository, INotification notification)
        {
            _repository = repository;
            _notification = notification;
        }      

        public decimal Handle(DDD destino, DDD origem, int minuto, EPlanoTelefonia plano)
        {
            

            return 0;
        }
    }
}