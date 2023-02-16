using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_mvvm_first_look.Models
{
    public class User : INotifyPropertyChanged
    {
        /// <summary>
        /// Fields 
        /// </summary>
        /// 
        private int userId { get; set; }
        private string username { get; set; } = string.Empty;
        private string password { get; set; } = string.Empty;
        private string email { get; set; } = string.Empty;
        private string phone { get; set; } = string.Empty;
        private string address { get; set; } = string.Empty;

        /// <summary>
        /// Properties
        /// </summary>
        public int UserId { 
            get => userId; 
            set {
                userId = value;
                OnPropertyChanged("UserId");
            }
        }

        public string Username { 
            get => username;
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Password { 
            get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public string Email { 
            get => email;
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Phone { 
            get => phone;
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
        public string Address { 
            get => address;
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }

        /// <summary>
        /// Functions
        /// </summary>
        /// 
        public override bool Equals(object? obj)
        {
            if (obj is User)
            {
                return this.userId == ((User)obj).UserId;
            }

            return base.Equals(obj);
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName) 
        { 
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
