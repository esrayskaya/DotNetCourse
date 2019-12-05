using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IUserDAO
    {
        void AddUser(Common.User user);
        void DeleteUser(Common.User user);
        System.Collections.Generic.IEnumerable<Common.User> GetUsersList();
    }
}
