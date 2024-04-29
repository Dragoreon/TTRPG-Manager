using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;
using TTRPG_Manager.Commands;
using TTRPG_Manager.Models.Lists;
using TTRPG_Manager.Models;
using TTRPG_Manager.ViewModels.OfModels;

namespace TTRPG_Manager.ViewModels.OfViews
{
    /// <summary>
    /// Clase que maneja los componentes de la vista SystemsView
    /// </summary>
    public class RuleSystemListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<RuleSystemViewModel> _systems;

        public IEnumerable<RuleSystemViewModel> RuleSystems => _systems;
        private ViewModelBase _currentListingViewModel {  get; set; }
        public RuleSystemListingViewModel(Stores.NavigationStore navigationStore, Func<RuleSystemListingViewModel> createSystemListingViewModel)
        {
            _systems = new ObservableCollection<RuleSystemViewModel>();
            meterDatosDePrueba();
        }

        private void meterDatosDePrueba()
        {
            RuleSystemBook<RuleSystem> ruleSystemBook = new RuleSystemBook<RuleSystem>();
            ruleSystemBook.Add(new RuleSystem("DND","5e"));
            ruleSystemBook.Add(new RuleSystem("Dungeon World",""));
            ruleSystemBook.Add(new RuleSystem("Ejemplo",""));
            ruleSystemBook.Add(new RuleSystem("Ejemplo",""));
            ruleSystemBook.Add(new RuleSystem("Ejemplo",""));
            ruleSystemBook.Add(new RuleSystem("Ejemplo",""));
            ruleSystemBook.Add(new RuleSystem("Ejemplo",""));
            foreach ( RuleSystem c in ruleSystemBook.GetAll()) _systems.Add(new RuleSystemViewModel(c));
        }
    }
}