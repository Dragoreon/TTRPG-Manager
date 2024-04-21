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
    public class GoToCampaignCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public GoToCampaignCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            // Todo: pasar la campaña en el constructor del viewmodels
            _navigationStore.CurrentViewModel = new CampaignDetailViewModel(new Campaign("Camp01",true));
        }
    }
}
