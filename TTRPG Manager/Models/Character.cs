using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TTRPG_Manager.Models
{
     public class Character
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public string Archetype { get; set; }
        public bool IsPlayable { get; set; }
        public FileAccess CharacterSheet { get; set; }
        public Image Image { get; set; }

        // Todo: Determinar la lógica de los puntos
        public Dictionary<string,object> Points { get; set; }
        public Player Player { get; set; }
        public AdventureBook<Adventure> Adventures{ get; set; } 
        public Character() { }
    }
}
