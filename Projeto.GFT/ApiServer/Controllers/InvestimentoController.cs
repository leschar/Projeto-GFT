using ApiServer.Domain.Interfaces;
using ApiServer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace ApiServer.Controllers
{
    public class InvestimentoController : ApiController
    {
        private readonly IInvestimentoService _investimentoService;

        public InvestimentoController(IInvestimentoService investimentoService)
        {
            _investimentoService = investimentoService;
        }

        [Microsoft.AspNetCore.Mvc.HttpPost("calcular")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public IHttpActionResult CalcularInvestimento([Microsoft.AspNetCore.Mvc.FromBody] InvestimentoRequest request)
        {

            var result = _investimentoService.CalcularInvestimento(request);
            return Ok(result);
        }
    }
}