using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Manager.Models.Lists;

namespace TTRPG_Manager.Models
{
    public class Library
    {
        private CampaignBook<Campaign> CampaignBook { get; set; }
        public Library(CampaignBook<Campaign> CampaignBook)
        {
            this.CampaignBook = CampaignBook;
        }

        public bool AddCampaign(Campaign campaign)
        {
            // Todo: comprobantes en algún punto
            CampaignBook.Add(campaign);
            return true;
        }
        
    }
}
