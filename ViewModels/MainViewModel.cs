using LibraryApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LibraryApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public object CurrentViewModel { get; set; }

        public ICommand GoDashboardCommand { get; }

        public MainViewModel()
        {
            GoDashboardCommand = new RelayCommand(ShowDashboard);
            ShowDashboard();
        }

        private void ShowDashboard()
        {
            CurrentViewModel = new DashboardViewModel();
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
