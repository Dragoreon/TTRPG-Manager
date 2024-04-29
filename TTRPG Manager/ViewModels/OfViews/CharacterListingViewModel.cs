using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TTRPG_Manager.Commands;
using TTRPG_Manager.Models;
using TTRPG_Manager.Models.Lists;

namespace TTRPG_Manager.ViewModels.OfViews
{
    public class CharacterListingViewModel : ViewModelBase
    {

        private readonly ObservableCollection<CharacterViewModel> _Characters;

        public IEnumerable<CharacterViewModel> Characters => _Characters;

        public CharacterListingViewModel(Stores.NavigationStore navigationStore)
        {
            _Characters = new ObservableCollection<CharacterViewModel>();
            meterDatosDePrueba();

        }

        private void meterDatosDePrueba()
        {
            _Characters.Add(new CharacterViewModel(new Character(1,DateTime.Now,"Personaje1","Herrero",true)));
            _Characters.Add(new CharacterViewModel(new Character(1,DateTime.Now,"Personaje2","Bardo",true)));
            _Characters.Add(new CharacterViewModel(new Character(1,DateTime.Now,"NPC1","Dragón",false)));
        }
    }
}
