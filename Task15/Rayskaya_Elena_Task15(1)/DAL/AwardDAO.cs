using System;
using System.Collections.Generic;

namespace DAL
{
    public class AwardDAO : IAwardDAO
    {
        private List<Common.Award> awards = new List<Common.Award>();
        
        public void AddAward(Common.Award award)
        {
            if (award == null)
            {
                throw new ArgumentException("award");
            }
            awards.Add(award);
        }
        public void DeleteAward(Common.Award award)
        {
            awards.Remove(award);
        }
        public IEnumerable<Common.Award> GetAwardsList()
        {
            return awards;
        }
    }
    public class AwardDAOdb : IAwardDAO
    {
        public void AddAward(Common.Award award)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Common.Award> GetAwardsList()
        {
            throw new NotImplementedException();
        }
        public void DeleteAward(Common.Award award)
        {
            throw new NotImplementedException();
        }
    }
}
