using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Manager.Models;

namespace TTRPG_Manager.ViewModels.OfModels
{
    public class RuleSystemViewModel
    {
        private readonly RuleSystem _ruleSystem;
        public string Name => _ruleSystem.Name;
        public string Edition => _ruleSystem.Edition;
        public DateTime CreationDate => _ruleSystem.CreationDate;
        public string SystemClass => _ruleSystem.SystemClass;
        public List<string> TagList => _ruleSystem.TagList;
        public RuleManualBook<RuleManual> RuleManuals => _ruleSystem.RuleManuals;
        public string FullName
        {
            get
            {
                if (Edition.Trim().Length == 0) return Name;
                return Name + " - " + Edition;
            }
        }

        public RuleSystemViewModel(RuleSystem ruleSystem)
        {
            _ruleSystem = ruleSystem;
        }
        
    }
}
