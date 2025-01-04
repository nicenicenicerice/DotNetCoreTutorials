using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestApp.Repositories
{
    public interface IUserRepository
    {
        public string GetPassword(int id);
    }
}
