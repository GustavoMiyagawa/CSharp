using UserService.App.Interfaces;
using UserService.Domain.Interfaces.Repositories;
using UserService.Repository.MongoDb.Repositories;
using UserService.Repository.MongoDb.Resources;
using UserService.Repository.MongoDb.Wrappers;
using UserService.Shared.Helpers;

namespace UserService.API.Extensions;

public static class DependencyInjection
{
    public static void AddResources(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton(LoadNoSqlDatabaseResources(configuration));
        services.AddSingleton<MongoDbClientWrapper>();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddSingleton<IUserService, App.Services.UserService>();
        services.AddSingleton<IUserRepository, UserRepository>();
    }

    private static NoSQLDatabaseResources LoadNoSqlDatabaseResources(IConfiguration configuration)
    {
        var resources = configuration.GetSection(nameof(NoSQLDatabaseResources)).Get<NoSQLDatabaseResources>() ??
                        new NoSQLDatabaseResources();
        resources.Host = EnvironmentHelper.GetStringEnvironmentValue("MONGO_DB_HOST");
        resources.Port = EnvironmentHelper.GetStringEnvironmentValue("MONGO_DB_PORT");
        resources.User = EnvironmentHelper.GetStringEnvironmentValue("MONGO_DB_USER");
        resources.Password = EnvironmentHelper.GetStringEnvironmentValue("MONGO_DB_PASSWORD");
        return resources;
    }
}