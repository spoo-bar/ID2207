using BusinessTier.Exceptions;
using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class LoginController
    {
        public LoginController()
        {

        }

        public User Login(string email, string password)
        {
            var users = Seed.Users;
            var user = users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                // TODO : Hash password and compare hashed password
                if(user.Password.Equals(password))
                {
                    return user;
                }
                else
                {
                    throw new LoginException("Incorrect password was entered");
                }
            }
            else
            {
                throw new LoginException("Could not find user with that email");
            }
        }
    }
}
