using PS.MoneyMate.Application.Common.Interfaces.Persistence.Base;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.Common.Interfaces.Persistence
{
    public interface IExchangeRateRepository : ICrudRepository<ExchangeRate>
    {
        Task<ExchangeRate?> GetRateAsync(Guid fromCurrencyId, Guid toCurrencyId); // Получить курс для пары валют
    }
}
