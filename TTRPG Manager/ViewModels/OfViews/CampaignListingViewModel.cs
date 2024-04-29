using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TTRPG_Manager.Commands;
using TTRPG_Manager.Models;
using TTRPG_Manager.Models.Lists;

namespace TTRPG_Manager.ViewModels.OfViews
{
    public class CampaignListingViewModel : ViewModelBase
    {

        private readonly ObservableCollection<CampaignViewModel> _campaigns;

        public IEnumerable<CampaignViewModel> Campaigns => _campaigns;
        public ICommand NewCampaignCommand { get; }
        public ICommand GoToCampaignCommand { get; }

        public CampaignListingViewModel(Stores.NavigationStore navigationStore, Func<CampaignDetailViewModel> createCampaignDetailViewModel)
        {
            _campaigns = new ObservableCollection<CampaignViewModel>();
            meterDatosDePrueba();

            GoToCampaignCommand = new NavigateCommand<CampaignListingViewModel>(navigationStore,createCampaignDetailViewModel);
        }

        private void meterDatosDePrueba()
        {
            AdventureBook<Adventure> ab = new AdventureBook<Adventure>();
            HashSet<string> taglist = new HashSet<string>();
            taglist.Add("tag1");
            taglist.Add("tag2");
            taglist.Add("tag3");
            ab.Add(new Adventure(1, DateTime.Now, "Aventura 1", null, true, taglist, null, null));
            ab.Add(new Adventure(2, DateTime.Now, "Aventura 2", null, true, taglist, null, null));
            ab.Add(new Adventure(3, DateTime.Now, "Aventura 3", null, true, taglist, null, null));

            CampaignBook<Campaign> campaignBook = new CampaignBook<Campaign>();
            campaignBook.Add(new Campaign(1, DateTime.Now, "El mar indigo", true, ab));
            campaignBook.Add(new Campaign(1, DateTime.Now, "Aventuras en el salvaje azul", false, ab));
            campaignBook.Add(new Campaign(1, DateTime.Now, "Dnd8", true, ab));
            foreach (Campaign c in campaignBook.GetAll()) _campaigns.Add(new CampaignViewModel(c));
        }
    }
}
