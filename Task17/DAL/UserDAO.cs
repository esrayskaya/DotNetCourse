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
        public void UpdateUser(Common.User user, int id)
        {
            int index = users.FindIndex(item => item.ID == id);
            users[index].LastName = user.LastName;
            users[index].FirstName = user.FirstName;
            users[index].DateOfBirthDay = user.DateOfBirthDay;
        }
        public IEnumerable<Common.Award> GetAwardsOfUser(Common.User user)
        {
            int index = users.FindIndex(item => item.ID == user.ID);
            return users[index].AwardsList;
        }
    }
}
