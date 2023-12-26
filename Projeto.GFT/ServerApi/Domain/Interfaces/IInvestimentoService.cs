using ServerApi.Domain.Models;

namespace ServerApi.Domain.Interfaces
{
    public interface IInvestimentoService
    {
        InvestimentoResponse CalcularInvestimento(InvestimentoRequest investimento);
    }
}
