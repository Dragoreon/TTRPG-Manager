using System.Windows.Input;
using TTRPG_Manager.Stores;
using TTRPG_Manager.ViewModels.OfViews;

namespace TTRPG_Manager.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public NavBarViewModel NavBarViewModel { get; }

        public ICommand NavigateRuleSystemsCommand => NavBarViewModel.NavigateSystemsCommand;
        public ICommand NavigateCampaignsCommand => NavBarViewModel.NavigateCampaignsCommand;
        public ICommand NavigateCharactersCommand => NavBarViewModel.NavigateCharactersCommand;


        public MainViewModel(NavigationStore navigationStore, NavBarViewModel navBarViewModel)
        {
            _navigationStore = navigationStore;
            NavBarViewModel = navBarViewModel;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
