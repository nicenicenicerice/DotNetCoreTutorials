using MsTestApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestApp.Logins
{
    public class Account
    {
        private IUserRepository _userRepo;

        public Account(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public bool Validate(int userId, string userPassword)
        {
            string truePassword = _userRepo.GetPassword(userId);
            return userPassword == truePassword;
        }
    }
}
