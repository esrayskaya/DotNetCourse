using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IAwardDAO
    {
        void AddAward(Common.Award award);
        void DeleteAward(Common.Award award);
        System.Collections.Generic.IEnumerable<Common.Award> GetAwardsList();
    }
}
