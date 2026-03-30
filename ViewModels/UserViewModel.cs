using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LibraryApp.ViewModels
{

    class UserViewModel
    {
        public ObservableCollection<UserDto> Users { get; set; }

        public UserViewModel()
        {
            Users = new ObservableCollection<UserDto>()        
            {
                new UserDto { Id = 1, Name = "Ariane", Date = DateTime.Now },
                new UserDto { Id = 2, Name = "John", Date = DateTime.Now }
            };
        }
    }
}
