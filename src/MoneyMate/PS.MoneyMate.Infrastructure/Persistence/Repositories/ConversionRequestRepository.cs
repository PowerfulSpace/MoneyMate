using Microsoft.EntityFrameworkCore;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Domain.Entities;

namespace PS.MoneyMate.Infrastructure.Persistence.Repositories
{
    public class ConversionRequestRepository : IConversionRequestRepository
    {
        private readonly MoneyMateDbContext _context;

        public ConversionRequestRepository(MoneyMateDbContext context)
        {
            _context = context;
        }

        // Получить все запросы
        public async Task<IEnumerable<ConversionRequest>> GetAllAsync()
        {
            return await _context.ConversionRequests.ToListAsync();
        }

        // Получить запрос по Id
        public async Task<ConversionRequest?> GetByIdAsync(Guid id)
        {
            return await _context.ConversionRequests.FirstOrDefaultAsync(x => x.Id == id);
        }

        // Добавить новый запрос
        public async Task AddAsync(ConversionRequest entity)
        {
            await _context.ConversionRequests.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        // Обновить запрос
        public async Task UpdateAsync(ConversionRequest entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Удалить запрос
        public async Task DeleteAsync(Guid id)
        {
            var request = new ConversionRequest { Id = id };
            _context.ConversionRequests.Attach(request);
            _context.Entry(request).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        // Получить запросы по диапазону дат
        public async Task<IEnumerable<ConversionRequest>> GetByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.ConversionRequests
                .Where(request => request.ConversionDate >= startDate && request.ConversionDate <= endDate)
                .ToListAsync();
        }
    }
}
