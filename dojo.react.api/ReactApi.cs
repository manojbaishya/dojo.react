using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Dojo.React;

public static class ReactApi
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = GetWebApplicationBuilder(args);
        WebApplication app = GetWebApplication(builder);
        app.Run();
    }

    private static WebApplication GetWebApplication(WebApplicationBuilder builder)
    {
        WebApplication app = builder.Build();

        app.UseDefaultFiles();
        app.UseStaticFiles();


        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.MapFallbackToFile("/index.html");
        return app;
    }

    private static WebApplicationBuilder GetWebApplicationBuilder(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder;
    }
}
