using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_mvvm_first_look.Core.Models;

namespace wpf_mvvm_first_look.State.Authenticators
{
    public interface IAuthenticator
    {
        User CurrentUser { get; }
        bool IsLoggedIn { get; }
        Task<bool> LoginAsync(string username, string password);
        void Logout(); 
    }
}
