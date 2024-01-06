using Quote.Application.Interfaces;
using Quote.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using Quote.Application.Services;

namespace Quote.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IClaimService, ClaimService>();
            services.AddTransient<IQuotationService, QuotationService>();
            services.AddSingleton<Quote.Application.Interfaces.ILogger, Quote.Logging.Logger>();
        }
    }
}
