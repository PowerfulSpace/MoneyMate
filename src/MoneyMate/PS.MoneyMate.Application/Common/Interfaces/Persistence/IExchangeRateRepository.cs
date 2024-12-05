using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.Common.Interfaces.Persistence
{
    public interface IExchangeRateRepository
    {
        Task<ExchangeRate> GetRateAsync(string fromCurrency, string toCurrency); // Получение курса обмена.
        Task AddOrUpdateRateAsync(ExchangeRate exchangeRate); // Добавление или обновление курса.
    }
}
