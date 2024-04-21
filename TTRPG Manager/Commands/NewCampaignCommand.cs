using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Manager.Models.Lists;
using TTRPG_Manager.Models;
using TTRPG_Manager.ViewModels.OfViews;
using System.Windows;

namespace TTRPG_Manager.Commands
{
    public class NewCampaignCommand : CommandBase
    {
        private readonly Library _library;
        private readonly CampaignDetailViewModel _campaignDetailViewModel;

        public NewCampaignCommand(CampaignDetailViewModel campaignDetailViewModel, Library library)
        {
            _campaignDetailViewModel = campaignDetailViewModel;
            _library = library;
            _campaignDetailViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_campaignDetailViewModel.Name) && base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            Campaign campaign = new Campaign(
                _campaignDetailViewModel.Name,
                _campaignDetailViewModel.IsInProcess);
            try
            {

            _library.AddCampaign(campaign);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void OnViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName== nameof(CampaignDetailViewModel.Name))
            {
                OnCanExecuteChanged();
            }
        }
    }
}
