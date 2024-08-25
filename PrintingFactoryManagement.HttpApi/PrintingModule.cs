using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace PrintingFactoryManagement.HttpApi;

public static class PrintingModule
{
    public static void AddPrintingModule(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.TagActionsBy(api =>
            {
                if (api.GroupName != null)
                {
                    return new[] { api.GroupName };
                }

                if (api.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
                {
                    return new[] { controllerActionDescriptor.ControllerName };
                }

                throw new InvalidOperationException("Unable to determine tag for endpoint.");
            });
            c.DocInclusionPredicate((name, api) => true);
        });
    } 
}