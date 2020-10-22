using BusinessTier.Exceptions;
using DataTier;
using System.Linq;

namespace BusinessTier
{
    public class LoginController
    {
        public User Login(string email, string password)
        {
            var users = Seed.users;
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
