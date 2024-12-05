using PS.MoneyMate.Application.Common.Interfaces.Persistence.Base;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.Common.Interfaces.Persistence
{
    public interface ICurrencyRepository : ICrudRepository<Currency>
    {
        Task<Currency?> GetByCodeAsync(string code); // Найти валюту по коду (например, "USD")
    }
}
