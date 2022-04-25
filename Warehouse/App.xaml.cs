using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows;
using Warehouse.Infrastructure.AutoMapperProfiles;
using Warehouse.Repository;
using Warehouse.Service;

namespace Warehouse
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Fields
        private readonly ServiceProvider _serviceProvider;
        private readonly ServiceCollection _services;
        #endregion

        #region Ctor
        public App()
        {
            _services = new ServiceCollection();            
            ConfigureServices(_services);
            _serviceProvider = _services.BuildServiceProvider();
        }
        #endregion

        #region Methods
        private void ConfigureServices(ServiceCollection services)
        {
            // DbContext
            var dbPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\NaBi\\Warehouse";
            if (!Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);
            }

            services.AddDbContext<WHContext>(options =>
            {
                options.UseSqlite("Data Source = " + dbPath + "\\Warehouse.db");
            });            

            // Automapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new WarehouseProfile());
            });

            var mapper = new Mapper(mapperConfig);
            services.AddSingleton<IMapper>(mapper);

            // Services
            services.AddSingleton<IWarehouseService, WarehouseService>();

            services.AddSingleton<MainWindow>();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {         
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow?.Show();                     
        }
        #endregion
    }
}
