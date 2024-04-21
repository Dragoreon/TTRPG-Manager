using System.Collections.Generic;
using System.Linq;
using TTRPG_Manager.Models.Lists;

namespace TTRPG_Manager.Models
{
    /// <summary>
    /// Clase que maneja una lista de Aventuras dentro de una Campaña
    /// </summary>
    public class AdventureBook<T> : BookBase<T> where T : Adventure
    {

        /// <summary>
        /// Devuelve una lista de aventuras donde el nombre contiene la cadena dada por el parámetro
        /// </summary>
        /// <param name="name"></param>
        public IEnumerable<T> Get(string name)
        {
            return _items.Where(r => r.Name.Contains(name));
        }

        public HashSet<string> GetAllTags()
        {
            HashSet<string> tags = new HashSet<string>();
            foreach (Adventure adventure in _items)
            {
                foreach (string tag in adventure.TagList)
                    tags.Add(tag);
            }
            return tags;
        }
    }
}
