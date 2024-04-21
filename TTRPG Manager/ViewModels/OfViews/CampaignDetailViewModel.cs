using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TTRPG_Manager.Commands;
using TTRPG_Manager.Models.Lists;
using TTRPG_Manager.Models;

namespace TTRPG_Manager.ViewModels.OfViews
{

    public class CampaignDetailViewModel : ViewModelBase
    {
        private readonly Campaign _campaign;

        private readonly ObservableCollection<AdventureViewModel> _adventures;
        public IEnumerable<AdventureViewModel> Adventures => _adventures;

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private bool _isInProcess = true;
        public bool IsInProcess
        {
            get
            {
                return _isInProcess;
            }
            set
            {
                _isInProcess = value;
                OnPropertyChanged(nameof(IsInProcess));
            }
        }
        public ICommand NewCampaignCommand { get; }


        public CampaignDetailViewModel(Campaign campaign)
        {
            _campaign = campaign;
            // TODO: En lugar de crear esto de cero, se saca de la BD
            ObservableCollection<CampaignViewModel>
            _campaigns = new ObservableCollection<CampaignViewModel>();
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



            NewCampaignCommand = new NewCampaignCommand(this, new Library(campaignBook));
        }


    }
}
