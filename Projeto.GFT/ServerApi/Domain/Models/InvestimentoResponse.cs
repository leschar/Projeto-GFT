using Newtonsoft.Json;
using System.ComponentModel;

namespace ServerApi.Domain.Models
{

    /// <summary>
    /// Retorna os valores após o calculo de investimento em CDB
    /// </summary>
    public class InvestimentoResponse
    {
        [DisplayName("Resultado Bruto")]
        [JsonProperty("resultadoBruto")]
        public decimal ResultadoBruto { get; set; }
        [DisplayName("Resultado Liquido")]
        [JsonProperty("resultadoLiquido")]
        public decimal ResultadoLiquido { get; set; }
    }
}
