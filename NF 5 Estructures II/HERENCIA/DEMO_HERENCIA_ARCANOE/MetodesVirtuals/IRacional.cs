using System;
using System.Collections.Generic;
using System.Text;

namespace MetodesVirtuals
{
    public interface IRacional
    {
        public int CI
        {
            get;set;
        }
        public void IncrementarCI(int incr);
    }
}
