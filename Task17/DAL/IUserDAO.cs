using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IUserDAO
    {
        void AddUser(Common.User user);
        void DeleteUser(Common.User user);
        void UpdateUser(Common.User user, int id);
        /*void AddAwardToUser(Common.User user, Common.Award award);
        void DeleteAwardOfUser(Common.User user, Common.Award award);*/
        System.Collections.Generic.IEnumerable<Common.User> GetUsersList();
        IEnumerable<Common.Award> GetAwardsOfUser(Common.User user);
    }
}
