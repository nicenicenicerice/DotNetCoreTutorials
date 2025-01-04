using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        public string GetPassword(int id)
        {
            string password = null;

            switch (id)
            {
                case 1:
                    password = "mima_1";
                    break;
                case 2:
                    password = "mima_2";
                    break;
                default:
                    password = null;
                    break;
            }

            return password;
        }
    }
}
