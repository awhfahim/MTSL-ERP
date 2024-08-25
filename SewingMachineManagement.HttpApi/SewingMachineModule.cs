using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace SewingMachineManagement.HttpApi;

public static class SewingMachineModule
{
    public static void AddSewingMachineModule(this IServiceCollection services)
    {
        services.AddSwaggerGen(cfg =>
        {
            cfg.SwaggerDoc("v1", new OpenApiInfo { Title = "Main API", Version = "v1" });
            cfg.SwaggerDoc("SewingMachine", new OpenApiInfo { Title = "Sewing Machine API", Version = "v1" });
        });
    }
}