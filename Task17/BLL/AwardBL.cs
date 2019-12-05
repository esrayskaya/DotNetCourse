using System;
using System.Collections.Generic;
using DAL;
using Common;

namespace BLL
{
    public class AwardBL
    {
        private readonly IAwardDAO awardsDAO;
        public AwardBL()
        {
            awardsDAO = new AwardDAO();
        }
        public void AddAward(Common.Award award)
        {
            if (award == null)
            {
                throw new ArgumentException("award");
            }
            awardsDAO.AddAward(award);
        }
        public void AddAward(string title, string description)
        {
            Common.Award award = new Award(title, description) /*{ Title = title, Description = description }*/;
            this.AddAward(award);
        }
        public void DeleteAwaed(Award user)
        {
            //User u = new User(/*user.FirstName, user.LastName, user.DateOfBirthDay, user.usersAwarda*/);
            awardsDAO.DeleteAward(user);
        }
        public IEnumerable<Common.Award> GetAwardsList()
        {
            return awardsDAO.GetAwardsList();
        }
        /*public IEnumerable<Common.Award> InitAwardsList()
        {
            AddAward(new Award() { Title = "Нобелевская премия", Description = "" });
            AddAward(new Award() { Title = "Оскар", Description = "2018" });
            return GetAwardsList();
        }*/
        public AwardBL(IAwardDAO award)
        {
            //this.usersDAO = new UsersDAO();
            awardsDAO = award;
        }
    }
}
