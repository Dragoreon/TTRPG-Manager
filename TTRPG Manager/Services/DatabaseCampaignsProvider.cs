using Microsoft.EntityFrameworkCore;
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
        private readonly TTRPGManagerDBContextFactory _dbContextFactory;

        public DatabaseCampaignsProvider(TTRPGManagerDBContextFactory factory)
        {
            _dbContextFactory = factory;
        }

        public async Task<IEnumerable<Campaign>> GetAllCampaigns()
        {
            using (TtrpgmanagerContext context = _dbContextFactory.CreateDBContext())
            {
                IEnumerable<CampaignDTO> campaignDTOs = await context.Campaigns.ToListAsync();
                return campaignDTOs.Select(r => ToCampaign(r));
            }
        }

        private Campaign ToCampaign(CampaignDTO dto)
        {
            //return new Campaign(dto.Id, dto.FechaCreacion, dto.Nombre, dto.EnProceso, dto.Aventuras);
            return new Campaign();
        }
    }
}
