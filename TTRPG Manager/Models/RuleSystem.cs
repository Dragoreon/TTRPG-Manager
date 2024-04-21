using System;
using System.Collections.Generic;

namespace TTRPG_Manager.Models
{
    public class RuleSystem
    {
        public string Name { get; set; }
        public string Edition { get; set; }
        public DateTime CreationDate { get; set; }
        public string SystemClass { get; set; }
        public List<string> TagList { get; set; }
        public RuleManualCollection<RuleManual> RuleManuals { get; set; }


        /// <summary>
        /// Constructor principal para obtener datos de la BD
        /// </summary>
        public RuleSystem(string name, string edition, DateTime creationDate, string systemClass, List<string> tagList)
        {
            Name = name;
            Edition = edition;
            CreationDate = creationDate;
            SystemClass = systemClass;
            TagList = tagList;
        }

        public RuleSystem(string name, string edition)
        {
            Name = name;
            Edition = edition;
            CreationDate = DateTime.Now;
            TagList = new List<string>();
        }

        public RuleSystem()
        {
        }



    }
}
