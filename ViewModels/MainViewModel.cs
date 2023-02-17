using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_mvvm_first_look.ViewModels
{
    public class MainViewModel : ViewModelBase
    { 
        public ICommand UpdateCurrentViewModelCommand { get; }

        public MainViewModel()
        {

        }


        public override void Dispose()
        {

            base.Dispose();
        }
    }
}
