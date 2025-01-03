using Todo.Application.Services;
using Todo.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Todo.Infrastructure.Repositories;

namespace Todo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ItemService>();
        services.AddSingleton<IItemRepository, ItemRepository>();
        return services;
    }
}