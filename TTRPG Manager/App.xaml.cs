using Microsoft.EntityFrameworkCore;
using System.Windows;
using TTRPG_Manager.DBContexts;
using TTRPG_Manager.Models;
using TTRPG_Manager.Services;
using TTRPG_Manager.Stores;
using TTRPG_Manager.ViewModels;
using TTRPG_Manager.ViewModels.OfViews;

namespace TTRPG_Manager
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Server=.\\SQLEXPRESS01;Database=TTRPGManager;Trusted_Connection=True;TrustServerCertificate=true";
        // "Server=localhost\\SQLEXPRESS01;Database=TTRPGManager"
        private readonly NavigationStore _navigatonStore;
        private readonly Library _library;
        private readonly TTRPGManagerDBContextFactory _DbContextFactory;

        public App()
        {
            _navigatonStore = new NavigationStore();
            _DbContextFactory = new TTRPGManagerDBContextFactory(CONNECTION_STRING);
            ICampaignProvider campaignProvider = new DatabaseCampaignsProvider(_DbContextFactory);
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            Window splashScreen = new SplashScreen();
            splashScreen.Show();

            // Todo: cargar datos
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer(CONNECTION_STRING).Options;
            TtrpgmanagerContext dbContext = new TtrpgmanagerContext(options, CONNECTION_STRING);
            dbContext.Database.Migrate();

            _navigatonStore.CurrentViewModel = CreateCampaignListingViewModel();
            //_navigatonStore.CurrentViewModel = CreateCampaignViewModel();

            // TODO: mover esta instancia a una interfaz de servicio
            NavBarViewModel navBarViewModel = new NavBarViewModel(
                CreateCampaignNavigationService(),
                CreateRuleSystemNavigationService(),
                CreateCharacterNavigationService()
                );

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigatonStore, navBarViewModel)
            };
            MainWindow.Show();

            base.OnStartup(e);
            splashScreen.Close();
        }

        private NavigationService<CampaignListingViewModel> CreateCampaignNavigationService()
        {
            return new NavigationService<CampaignListingViewModel>(_navigatonStore, () => new CampaignListingViewModel(_navigatonStore, null));
        }
        private NavigationService<RuleSystemListingViewModel> CreateRuleSystemNavigationService()
        {
            return new NavigationService<RuleSystemListingViewModel>(_navigatonStore, () => new RuleSystemListingViewModel(_navigatonStore, null));
        }

        //TODO esto es para crear el resto de botones de la nav bar. (agregar al constructor de NavBarViewModel
        private NavigationService<CharacterListingViewModel> CreateCharacterNavigationService()
        {
            return new NavigationService<CharacterListingViewModel>(_navigatonStore, () => new CharacterListingViewModel(_navigatonStore));
        }
        //private NavigationService<PlayerListingViewModel> CreatePlayerNavigationService()
        //{
        //    return new NavigationService<PlayerListingViewModel>(_navigatonStore, () => new PlayerListingViewModel(_navigatonStore, null));
        //}


        // TODO esto es para crear los ViewModels iniciales
        //private ViewModelBase CreateCampaignCrudTestViewModel()
        //{
        //    //throw new NotImplementedException();
        //}

        private CampaignDetailViewModel CreateCampaignDetailViewModel()
        {
            return new CampaignDetailViewModel(null, _navigatonStore, null);
        }

        private CampaignListingViewModel CreateCampaignListingViewModel()
        {
            return new CampaignListingViewModel(_navigatonStore, CreateCampaignDetailViewModel);
        }


    }
}
