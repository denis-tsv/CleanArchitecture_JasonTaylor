using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Infrastructure.Files;
using CleanArchitecture.Infrastructure.Services;
using CleanArchitecture.WebUI.Services;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IDateTime, DateTimeService>();
        services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        
        return services;
    }
}
