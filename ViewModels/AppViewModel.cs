using LibraryApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        public object CurrentViewModel { get; set; }

        public AppViewModel()
        {
            ShowLogin();
        }

        public void ShowLogin()
        {
            CurrentViewModel = new LoginViewModel(OnLoginSuccess);
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private void OnLoginSuccess()
        {
            CurrentViewModel = new MainViewModel();
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
