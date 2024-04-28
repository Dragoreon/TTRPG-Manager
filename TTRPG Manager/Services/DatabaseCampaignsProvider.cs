using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTRPG_Manager.DBContexts;
using TTRPG_Manager.DTOs;
using TTRPG_Manager.Models;

namespace TTRPG_Manager.Services
{
    public class DatabaseCampaignsProvider : ICampaignProvider
    {
        private readonly TTRPGManagerDesignTimeDbContextFactory _factory;
        
        public DatabaseCampaignsProvider(TTRPGManagerDesignTimeDbContextFactory factory)
        {
            _factory = factory;
        }

        public async Task<IEnumerable<Campana>> GetAllCampaigns()
        {
            using (TtrpgmanagerContext context = _factory.CreateDbConection())
            {
                List<Campana> campaignDTOs = await context.Campanas.ToListAsync();
                return campaignDTOs;
            }
        }
    }
}
