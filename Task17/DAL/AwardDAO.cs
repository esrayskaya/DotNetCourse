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
        public void UpdateAward(Common.Award award, int id)
        {
            int index = awards.FindIndex(item => item.ID == id);
            awards[index].Title = award.Title;
            awards[index].Description = award.Description;
        }
        public IEnumerable<Common.Award> GetAwardsList()
        {
            return awards;
        }
    }
}
