using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_mvvm_first_look.Core.Services;
using wpf_mvvm_first_look.Core.Models;

namespace wpf_mvvm_first_look.State.Authenticators
{
    public class Authenticator : IAuthenticator
    {
        private readonly IAuthenticationService _authenticationService;

        public Authenticator(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public User CurrentUser { get; private set; }

        public bool IsLoggedIn => CurrentUser != null;

        public async Task<bool> LoginAsync(string username, string password)
        {
            try
            {
                CurrentUser = _authenticationService.Login(username, password);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
