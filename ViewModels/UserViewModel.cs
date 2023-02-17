using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_mvvm_first_look.Models;
using wpf_mvvm_first_look.Commands;
using System.Windows;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace wpf_mvvm_first_look.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        /// <summary>
        /// Fields
        /// </summary>
        private ObservableCollection<User>? users { get; set; }
        private User user { get; set; }
        private string message { get; set; }= string.Empty;
        /// <summary>
        /// Properties
        /// </summary>
        public ObservableCollection<User> Users
        {
            get => users ?? new();
            set
            {
                users = value;
                OnPropertyChanged("Users");
            }
        }

        public User User
        {
            get => user;
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }

        public string Message
        {
            get => message;
            set { message = value; OnPropertyChanged("Message");}
        }

        public UserViewModel()
        {
            Task.Run(() => UserService.GetUser());

            this.users = new ObservableCollection<User>(UserService.GetObjUserList());
            this.user = UserService.GetSigleUser(2);

            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.command = new RelayCommand( obj =>
            {
                this.Message = obj?.ToString() ?? "";
            });
        }

        

        ///
        private RelayCommand command;

        public RelayCommand Command
        {
            get { return command; }
            set { command = value; }
        }

    }
}
