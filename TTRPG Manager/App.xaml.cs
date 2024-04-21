using System.Windows;
using TTRPG_Manager.Models;
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
        private readonly NavigationStore _navigatonStore;
        private readonly Library _library;


        public App()
        {
            _navigatonStore = new NavigationStore();
            // TODO: instanciar la biblioteca desde la BD
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            // Todo: cargar datos

            _navigatonStore.CurrentViewModel = new CampaignListingViewModel(_navigatonStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigatonStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
