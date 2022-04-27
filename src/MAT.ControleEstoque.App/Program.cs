using MAT.ControleEstoque.Business.Interfaces;
using MAT.ControleEstoque.Business.Services;
using MAT.ControleEstoque.Data.Builder;
using MAT.ControleEstoque.Data.Configurations;
using MAT.ControleEstoque.Data.Core;
using MAT.ControleEstoque.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MAT.ControleEstoque.App
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; set; }

        public static IServiceProvider ServiceProvider { get; set; }

        private static string SQL_SERVER_SETTINGS = "SqlServerSettings";

        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();
            var frm = ServiceProvider.GetRequiredService<frmLogin>();
            Application.Run(frm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Forms
            services.AddTransient<frmLogin>();
            services.AddTransient<frmMain>();
            services.AddTransient<frmClient>();
            services.AddTransient<frmClientSearch>();
            services.AddTransient<frmUser>();

            // Services
            services.AddSingleton<IAppService, AppService>();

            // Repository
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            // Builder
            services.AddTransient<IClientBuilder, ClientBuilder>();
            services.AddTransient<ISystemUserBuilder, SystemUserBuilder>();

            // Data
            services.AddTransient<IDbService, DbService>();

            // SqlServer
            var sqlSettings = new DbConfig();
            Configuration.Bind(SQL_SERVER_SETTINGS, sqlSettings);
            services.AddSingleton(sqlSettings);
        }
    }
}