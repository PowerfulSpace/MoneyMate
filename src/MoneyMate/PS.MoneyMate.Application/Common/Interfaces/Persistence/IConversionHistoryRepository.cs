namespace PS.MoneyMate.Application.Common.Interfaces.Persistence
{
    public interface IConversionHistoryRepository
    {
        Task SaveRequestAsync(ConversionRequest request); // Сохранение запроса.
        Task<IEnumerable<ConversionRequest>> GetHistoryAsync(); // Получение истории запросов.
    }
}
