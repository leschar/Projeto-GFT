namespace ServerApi.Domain.Interfaces
{
    public interface IImpostoRepository
    {
        public Dictionary<int, decimal> Imposto();
    }
}
