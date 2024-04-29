using System.Windows.Input;
using TTRPG_Manager.Commands;
using TTRPG_Manager.Services;

namespace TTRPG_Manager.ViewModels.OfViews
{
    public class NavBarViewModel : ViewModelBase
    {
        public ICommand NavigateCampaignsCommand { get; }
        public ICommand NavigatePlayersCommand { get; }
        public ICommand NavigateSystemsCommand { get; }
        public ICommand NavigateCharactersCommand { get; }

        public NavBarViewModel(
            NavigationService<CampaignListingViewModel> campaignNavigationService,
            NavigationService<RuleSystemListingViewModel> systemNavigationService,
            NavigationService<CharacterListingViewModel> characterNavigationService)
        {
            NavigateCampaignsCommand = new NavigateCommand<CampaignListingViewModel>(campaignNavigationService);
            NavigateSystemsCommand = new NavigateCommand<RuleSystemListingViewModel>(systemNavigationService);
            NavigateCharactersCommand = new NavigateCommand<CharacterListingViewModel>(characterNavigationService);
            //NavigatePlayersCommand = new NavigateCommand<PlayerViewModel>(playerNavigationService);
        }

    }
}
