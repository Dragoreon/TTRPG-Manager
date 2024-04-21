using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.Models.Lists
{
    public class CampaignBook<T> : BookBase<T> where T : Campaign
    {
        public CampaignBook() : base() { }

        /// <summary>
        /// Devuelve una lista de campañas donde el nombre contiene la cadena dada por el parámetro
        /// </summary>
        /// <param name="name">El nombre a comparar</param>
        public IEnumerable<Campaign> Get(string name)
        {
            return _items.Where(r => r.Name.Contains(name));
        }
    }
}
