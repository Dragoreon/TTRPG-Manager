using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using TTRPG_Manager.Models;
using TTRPG_Manager.Services;
using TTRPG_Manager.Stores;
using TTRPG_Manager.ViewModels;
using TTRPG_Manager.ViewModels.OfViews;

namespace TTRPG_Manager.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;
        private readonly NavigationService<TViewModel> _navigationService;

        public NavigateCommand(NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            this._createViewModel = createViewModel;
        }

        public NavigateCommand(NavigationService<TViewModel> navigationService) { 
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            // Todo: pasar la campaña en el constructor del viewmodels
            _navigationService.Navigate();
            //_navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
