using Microsoft.Extensions.DependencyInjection;

namespace SimpleChatApplication.Application;

public static class RegistrationExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IChatService, ChatService>();

        return services;
    }
}
