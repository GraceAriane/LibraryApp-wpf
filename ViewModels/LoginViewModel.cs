using LibraryApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LibraryApp.ViewModels
{
    public class LoginViewModel
    {
        private readonly Action _onSuccess;

        public ICommand LoginCommand { get; }

        public LoginViewModel(Action onSuccess)
        {
            _onSuccess = onSuccess;
            LoginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            _onSuccess();

        }
    }
}
