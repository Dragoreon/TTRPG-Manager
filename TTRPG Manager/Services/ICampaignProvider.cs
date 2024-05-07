using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Manager.DTOs;
using TTRPG_Manager.Models;

namespace TTRPG_Manager.Services
{
    public interface ICampaignProvider
    {
        Task<IEnumerable<Campaign>> GetAllCampaigns();
    }
}
