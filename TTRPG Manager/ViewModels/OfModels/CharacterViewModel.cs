using System;
using System.Collections.Generic;
using TTRPG_Manager.Models;

namespace TTRPG_Manager.ViewModels
{
    public class CharacterViewModel : ViewModelBase
    {
        private readonly Character _Character;

        public int Id => _Character.Id;
        public string Name => _Character.Name;
        public string Archetype => _Character.Archetype;
        public DateTime CreationDate => _Character.CreationDate;
        public bool IsPlayable => _Character.IsPlayable;

        public CharacterViewModel(Character Character)
        {
            _Character = Character;
        }

    }
}
