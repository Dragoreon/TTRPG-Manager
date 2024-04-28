using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Manager.Models;
using TTRPG_Manager.Stores;
using TTRPG_Manager.ViewModels;
using TTRPG_Manager.ViewModels.OfViews;

namespace TTRPG_Manager.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            this._createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            // Todo: pasar la campaña en el constructor del viewmodels
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
