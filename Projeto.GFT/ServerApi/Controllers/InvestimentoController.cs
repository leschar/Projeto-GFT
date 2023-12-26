using Microsoft.AspNetCore.Mvc;
using ServerApi.Domain.Interfaces;
using ServerApi.Domain.Models;

namespace ServerApi.Controllers
{


    [Route("api/investimento")]
    [ApiController]
    public class InvestimentoController : Controller
    {
        private readonly IInvestimentoService _investimentoService;

        public InvestimentoController(IInvestimentoService investimentoService)
        {
            _investimentoService = investimentoService;
        }

        [HttpPost("calcular")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public IActionResult CalculateInvestment([FromBody] InvestimentoRequest request)
        {

            var result = _investimentoService.CalcularInvestimento(request);
            return Ok(result);
        }
    }
}
