using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TTRPG_Manager.ViewModels
{
    internal class SearchToolBarViewModel : ViewModelBase
    {
        public SearchToolBarViewModel() { }
        public ICommand SearchCommand { get; }
        public ICommand FilterCommand { get; }
        public ICommand ListViewCommand { get; }
        public ICommand CardViewCommand { get; }
    }
}
