using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationTier
{
    sealed class Session
    {
        private static Session _userSession = null;

        public User LoggedInUser { get; set; }

        private Session() { }

        public static Session UserSession
        {
            get
            {
                if(_userSession == null)
                {
                    _userSession = new Session();
                }
                return _userSession;
            }
        }
    }
}
