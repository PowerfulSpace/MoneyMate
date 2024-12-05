using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.Common.Interfaces.Persistence
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> GetAllAsync(); // Получение списка валют.
        Task<Currency> GetByCodeAsync(string code); // Получение валюты по коду.
    }
}
