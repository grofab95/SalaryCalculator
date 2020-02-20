using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SalaryCalculator.SalaryReport;
using System.Collections.Generic;

namespace SalaryCalculator.Blazor
{
    public class Startup
    {
        private static readonly AppSettings _appSettings = new AppSettings();
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //configuration.GetSection(key: "AppSettings").Bind(_appSettings);
            var monthsWorkingHoursConfiguration =
                JsonFileConverter.JsonFileConverter.ConvertFromFile<Dictionary<int, int>>
                    ("MonthConfig.json");
            _appSettings.MonthsWorkingHours = new MonthsWorkingHours(monthsWorkingHoursConfiguration);
            _appSettings.CalculationsSummary = new CalculationsSummary();
            _appSettings.Calculator = new Calculator(_appSettings.MonthsWorkingHours);
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<MonthsWorkingHours>(_appSettings.MonthsWorkingHours);
            //services.AddSingleton<CalculationsSummary>(_appSettings.CalculationsSummary);
            services.AddSingleton<Calculator>(_appSettings.Calculator);
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors(core => core
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
