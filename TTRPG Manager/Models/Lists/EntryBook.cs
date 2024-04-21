using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.Models.Lists
{
    public class EntryBook<T> : BookBase<T> where T : Entry
    {
        public EntryBook() : base() { }

        /// <summary>
        /// Devuelve una lista de entradas donde el nombre contiene la cadena dada por el parámetro
        /// </summary>
        /// <param name="name">El nombre a comparar</param>
        public IEnumerable<Entry> Get(string name)
        {
            return _items.Where(r => r.Titulo.Contains(name));
        }
    }
}
