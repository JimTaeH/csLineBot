using System.IO;
using Line;
using MyLineBot.ConfigurationLINE;
using MyLineBot.EventHandlers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MyLineBot.Data;
using Microsoft.EntityFrameworkCore;

namespace MyLineBot
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton<ILineConfiguration, LineConfiguration>()
                .AddSingleton<ILineBot, LineBot>();

            services
                .AddSingleton<ILineBotLogger, MyLineBotLogger>()
                .AddSingleton<MyLineBotConfiguration>()
                .AddSingleton<LineBotService>();

            services
                .AddSingleton<ILineEventHandler, MessageEventHandler>()
                .AddSingleton<ILineEventHandler, PostbackEventHandler>();

            services
                .AddDbContext<DataContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DataContext")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var lineConfiguration = (LineConfiguration)app.ApplicationServices.GetRequiredService<ILineConfiguration>();
            _configuration.Bind("LineConfiguration", lineConfiguration);

            var lineBotSampleConfiguration = app.ApplicationServices.GetRequiredService<MyLineBotConfiguration>();
            _configuration.Bind("LineBotSampleConfiguration", lineBotSampleConfiguration);

            var lineBotService = app.ApplicationServices.GetRequiredService<LineBotService>();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Resources")),
                RequestPath = "/Resources"
            });

            app.Run(async (context) =>
            {
                await lineBotService.Handle(context);
            });
        }
    }
}