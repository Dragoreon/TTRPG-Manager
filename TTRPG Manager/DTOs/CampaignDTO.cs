using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.DTOs
{
    public class CampaignDTO
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public bool IsInProcess { get; set; }

    }
}
