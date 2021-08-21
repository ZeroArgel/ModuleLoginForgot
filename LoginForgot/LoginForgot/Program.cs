namespace LoginForgot
{
    #region usings.
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System;
    using System.Windows.Forms;
    using LoginForgot.Views.Login;
    using Interfaces;
    using Core;
    using DataAccess.Interfaces;
    using DataAccess.Core;
    using Models;
    #endregion
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.AddJsonFile("appsettings.json", optional: true);
                }).ConfigureServices((context, services) =>
                {
                    ConfigureServices(context.Configuration, services);
                }).Build();

            var iRetrieveServicesLogins = host.Services.GetService<IRetrieveServicesLogins>();
            var iWriteServicesLogins = host.Services.GetService<IWriteServicesLogins>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(iRetrieveServicesLogins, iWriteServicesLogins));
        }
        #region ConfigureServices
        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.Configure<TwilioOptions>(configuration.GetSection(nameof(TwilioOptions)));

            // DI from Core.
            services.AddScoped<IRetrieveServicesAdmin, RetrieveServicesAdmin>();
            services.AddScoped<IRetrieveServicesLogins, RetrieveServicesLogins>();
            services.AddScoped<IWriteServicesAdmin, WriteServicesAdmin>();
            services.AddScoped<IWriteServicesLogins, WriteServicesLogins>();

            // DI from DataAccess.
            services.AddScoped<IServicesCreate, ServicesCreate>();
            services.AddScoped<IServicesRead, ServicesRead>();
            services.AddScoped<IServicesUpdate, ServicesUpdate>();
        }
        #endregion
    }
}