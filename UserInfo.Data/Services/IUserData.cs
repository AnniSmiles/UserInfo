using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Data.Models;

namespace UserInfo.Data.Services
{
    public interface IUserData
    {
        IEnumerable<User> GetAll();
    }
}
