using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PS.MoneyMate.Application.Common.Interfaces.Persistence;
using PS.MoneyMate.Infrastructure.Persistence;
using PS.MoneyMate.Infrastructure.Persistence.Repositories;

namespace PS.MoneyMate.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services
               .AddPersistance(configuration);

            services.AddScoped<IConversionRequestRepository, ConversionRequestRepository>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<IExchangeRateRepository, ExchangeRateRepository>();

            return services;
        }
        private static IServiceCollection AddPersistance(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<MoneyMateDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}


// Добавить конфигурацию