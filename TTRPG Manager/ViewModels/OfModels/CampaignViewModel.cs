using System;
using System.Collections.Generic;
using TTRPG_Manager.Models;

namespace TTRPG_Manager.ViewModels
{
    public class CampaignViewModel : ViewModelBase
    {
        private readonly Campaign _campaign;

        public int Id => _campaign.Id;
        public string Name => _campaign.Name;
        public DateTime CreationDate => _campaign.CreationDate;
        public bool IsInProcess => _campaign.IsInProcess;
        public string TagList => _campaign.TagListString();

        //Todo: cambiar esto a una observable collection?
        public AdventureBook<Adventure> AdventureBook => _campaign._adventureBook;

        public CampaignViewModel(Campaign campaign)
        {
            _campaign = campaign;
        }

    }
}
