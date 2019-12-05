using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UserDAO : IUserDAO
    {
        private List<Common.User> users = new List<Common.User>();
        public void AddUser(Common.User user)
        {
            if (user == null)
            {
                throw new ArgumentException("user");
            }
            users.Add(user);
        }
        public void DeleteUser(Common.User user)
        {
            users.Remove(user);
        }
        public IEnumerable<Common.User> GetUsersList()
        {
            return users;
        }

    }
    public class UserDAOdb : IUserDAO
    {
        public void AddUser(Common.User user)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Common.User> GetUsersList()
        {
            throw new NotImplementedException();
        }
        public void DeleteUser(Common.User user)
        {
            throw new NotImplementedException();
        }
    }
}
