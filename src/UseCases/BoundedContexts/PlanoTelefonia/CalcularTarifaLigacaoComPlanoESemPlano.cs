using System.Collections.Generic;
using vxTel.Domain.Enumerators;
using vxTel.UseCase.Interfaces;

namespace vxTel.UseCase.BoundedContexts.PlanoTelefonia
{
    public class CalcularTarifaLigacaoComPlanoESemPlano : ICalcularTarifaLigacaoComPlanoESemPlano
    {
        private readonly ICalcularValorLigacao _useCase;

        public CalcularTarifaLigacaoComPlanoESemPlano(ICalcularValorLigacao calcularValorLigacao)
        {
            _useCase = calcularValorLigacao;
        }

        public List<decimal> Execute(int dddOrigem, int dddDestino, int duracaoEmMinutos, EPlanoTelefonia planoSelecionado)
        {
            return new List<decimal>()
            {
               _useCase.Execute(dddOrigem, dddDestino, duracaoEmMinutos, (int)EPlanoTelefonia.PlanoPadrao),
               _useCase.Execute(dddOrigem, dddDestino, duracaoEmMinutos, planoSelecionado)
            };
        }
    }
}