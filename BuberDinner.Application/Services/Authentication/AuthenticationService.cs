using BuberDinner.Application.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
        {
            //Check for the user already exists

            //Register the user

            //Generate the token
            var userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, FirstName, LastName);
            return new AuthenticationResult(userId, FirstName, LastName, Email, token);
        }

        public AuthenticationResult Login(string Email, string Password)
        {
            return new AuthenticationResult(Guid.NewGuid(), "Sethu", "Bharathi", Email, "Token");
        }
    }
}
