using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class UserBL
    {
        private readonly IUserDAO usersDAO;
        public UserBL()
        {
            usersDAO = new UserDAO();
        }
        public void AddUser(Common.User user)
        {
            if (user == null)
            {
                throw new ArgumentException("user");
            }
            usersDAO.AddUser(user);
        }
        public void DeleteUser(User user)
        {
            //User u = new User(/*user.FirstName, user.LastName, user.DateOfBirthDay, user.usersAwarda*/);
            usersDAO.DeleteUser(user);
        }
        public void UpdateUser(User user, int userID)
        {
            usersDAO.UpdateUser(user, userID);
        }
        public void AddUser(string firstname, string lastname, DateTime birthday/*, string award*/)
        {
            Common.User user = new User(firstname, lastname, birthday) /*{ FirstName = firstname, LastName = lastname, DateOfBirthDay = birthday, usersAwarda=award }*/;
            this.AddUser(user);
        }
        public IEnumerable<Common.User> GetUsersList()
        {
            return usersDAO.GetUsersList();
        }
        /*public IEnumerable<Common.User> InitUsersList()
        {
            AddUser(new User() { FirstName = "Мария", LastName = "Иванова", DateOfBirthDay = DateTime.Parse("25.11.1998") });
            AddUser(new User() { FirstName = "Иван", LastName = "Петров", DateOfBirthDay = DateTime.Parse("12.01.1999") });
            return GetUsersList();
        }*/
        public UserBL(IUserDAO user)
        {
            //this.usersDAO = new UsersDAO();
            usersDAO = user;
        }
    }
}
