using Microsoft.AspNetCore.Mvc;
using vxTel.Adapter.Application.Interfaces;
using vxTel.Adapter.Application.ViewModel;

namespace vxTel.WebServiceAdapter.UseCaseController.PlanoTelefonia
{
    [Route("api/v1/falemais")]
    [ApiController]
    public class CalcularValorDeUmaLigacaoController : ControllerBase
    {
        private readonly IPlanoTelefoniaApplication _useCase;

        public CalcularValorDeUmaLigacaoController(IPlanoTelefoniaApplication planoTelefoniaApplication)
        {
            _useCase = planoTelefoniaApplication;
        }
        
        [HttpGet("calcular-tarifa-ligacao")]
        public IActionResult UseCase(FaleMaisViewModel viewModel)
        {
            return Ok(_useCase.CalcularLigacaoPorPlano(viewModel));
        }
    }
}