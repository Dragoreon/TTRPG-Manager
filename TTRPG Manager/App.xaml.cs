using Microsoft.EntityFrameworkCore;
using System.Windows;
using TTRPG_Manager.DBContexts;
using TTRPG_Manager.Models;
using TTRPG_Manager.Services;
using TTRPG_Manager.Stores;
using TTRPG_Manager.ViewModels;

namespace TTRPG_Manager
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Server=localhost\\SQLEXPRESS01;Database=TTRPGManager";
        // "Server=.\\SQLEXPRESS01;Database=TTRPGManager;Trusted_Connection=True;TrustServerCertificate=true"
        private readonly NavigationStore _navigatonStore;
        private readonly Library _library;
        private readonly TTRPGManagerDesignTimeDbContextFactory _designTimeDbContextFactory;

        public App()
        {
            _navigatonStore = new NavigationStore();
            _designTimeDbContextFactory = new TTRPGManagerDesignTimeDbContextFactory(CONNECTION_STRING);
            ICampaignProvider campaignProvider = new DatabaseCampaignsProvider(_designTimeDbContextFactory);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            // Todo: cargar datos
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer(CONNECTION_STRING).Options;
            TtrpgmanagerContext dbContext = new TtrpgmanagerContext(options);
            dbContext.Database.Migrate();

            _navigatonStore.CurrentViewModel = CreateCampaignCrudTestViewModel();
            //_navigatonStore.CurrentViewModel = CreateCampaignViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigatonStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private ViewModelBase CreateCampaignCrudTestViewModel()
        {
            //throw new NotImplementedException();
            return null;
        }

        //private CampaignDetailViewModel CreateCampaignDetailViewModel()
        //{
        //    return new CampaignDetailViewModel(_library,_navigatonStore,CreateCampaignDetailViewModel);
        //}

        //private CampaignListingViewModel CreateCampaignViewModel()
        //{
        //    return new CampaignListingViewModel(_navigatonStore,CreateCampaignDetailViewModel);
        //}


    }
}
