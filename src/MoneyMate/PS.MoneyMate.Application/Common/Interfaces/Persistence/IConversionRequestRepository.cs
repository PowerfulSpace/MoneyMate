using PS.MoneyMate.Application.Common.Interfaces.Persistence.Base;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Application.Common.Interfaces.Persistence
{
    public interface IConversionRequestRepository : ICrudRepository<ConversionRequest>
    {
        Task<IEnumerable<ConversionRequest>> GetByDateRangeAsync(DateTime startDate, DateTime endDate); // Найти запросы по диапазону дат
    }
}
