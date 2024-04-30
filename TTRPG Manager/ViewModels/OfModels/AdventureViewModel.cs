using System;
using System.Collections.Generic;
using TTRPG_Manager.Models;

namespace TTRPG_Manager.ViewModels
{
    public class AdventureViewModel : ViewModelBase
    {
        private readonly Adventure _adventure;

        public int Id => _adventure.Id;
        public string Name => _adventure.Name;
        public DateTime CreationDate => _adventure.CreationDate;
        public bool IsInProcess => _adventure.IsInProcess;
        private HashSet<string> _tagList => _adventure.TagList;
        public string IsInProcessString
        {
            get
            {
                if (IsInProcess) return "En proceso";
                return "Terminado";
            }
        }

        public string TagList => _adventure.TagListString();

        public AdventureViewModel(Adventure adventure)
        {
            _adventure = adventure;
        }

    }
}
