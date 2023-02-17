using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_mvvm_first_look.ViewModels
{
    public class MainViewModel : ViewModelBase
    { 
        private string message { get; set; } = "Sinthon is a good student";
        public string Message
        {
            get => message;
            set {
                message = value;
                OnPropertyChanged("Message");
            }
        }

        public MainViewModel()
        {

        }
    }
}
