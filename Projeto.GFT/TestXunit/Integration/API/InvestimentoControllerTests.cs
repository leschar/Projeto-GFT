using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using ServerApi.Domain.Models;
using System.Net;
using System.Text;
namespace TestXunit.Integration.API
{
    public class InvestimentoControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public InvestimentoControllerTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CAlcularInvestimento_Input_VAlido_ReturnsOk()
        {
            // Arrange
            var investimento = new InvestimentoRequest { Meses = 6, Valor = 100 };
            var content = new StringContent(JsonConvert.SerializeObject(investimento), Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync("/api/investimento/calcular", content);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task CalcularInvestimento_InputInvalido_ReturnsBadRequest()
        {
            // Arrange
            InvestimentoRequest investimento = null;
            var content = new StringContent(JsonConvert.SerializeObject(investimento), Encoding.UTF8, "application/json");

            // Act
            var response = await _client.PostAsync("/api/investimento/calcular", content);

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
