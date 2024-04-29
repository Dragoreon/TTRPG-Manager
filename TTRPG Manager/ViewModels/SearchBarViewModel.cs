using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TTRPG_Manager.ViewModels
{
    public class SearchBarViewModel : ViewModelBase
    {
		private string search;
		public string Search
		{
			get
			{
				return search;
			}
			set
			{
				search = value;
				OnPropertyChanged(nameof(Search));
			}
		}

		
	}
}
