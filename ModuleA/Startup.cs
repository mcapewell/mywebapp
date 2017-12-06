using OrchardCore.Modules;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;

namespace ModuleA
{
    public class Startup : StartupBase
    {
        public override void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaRoute
            (
                name: "Home",
                areaName: "ModuleA",
                template: "",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
