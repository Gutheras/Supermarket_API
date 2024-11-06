using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Supermarket.API.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(cfg =>
            {
                cfg.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "G & S _Supermarket API",
                    Version = "v1",
                    Description = "This a simple RESTful API task built with ASP.NET Core to show how to create RESTful services using a service-oriented architecture.",
                    Contact = new OpenApiContact
                    {
                        Name = "Gutheras",
                        Url = new Uri("https://my-portfolio-4oj.pages.dev/")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                cfg.IncludeXmlComments(xmlPath);
            });
            return services;
        }

        public static IApplicationBuilder UseCustomSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger().UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Supermarket API");
                options.DocumentTitle = "Supermarket API";
            });
            return app;
        }
    }
}
