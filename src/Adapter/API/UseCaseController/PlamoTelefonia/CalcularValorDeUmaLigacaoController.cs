using Microsoft.AspNetCore.Mvc;
using vxTel.Adapter.Application.Interfaces;
using vxTel.Adapter.Application.ViewModel;

namespace vxTel.WebServiceAdapter.UseCaseController.PlamoTelefonia
{
    [Route("api/v1/falemais")]
    [ApiController]
    public class CalcularValorDeUmaLigacaoController : ControllerBase
    {
        private readonly IPlanoTelefoniaApplication _planoTelefoniaApplication;

        public CalcularValorDeUmaLigacaoController(IPlanoTelefoniaApplication planoTelefoniaApplication)
        {
            _planoTelefoniaApplication = planoTelefoniaApplication;
        }
        
        [HttpGet("calcular-tarifa-ligacao")]
        public IActionResult UseCase([FromQuery]FaleMaisViewModel viewModel)
        {
            return Ok(_planoTelefoniaApplication.CalcularCustoDeUmaLigacao(viewModel));
        }
    }
}