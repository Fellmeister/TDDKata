using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalc.Core
{
    public class Methods
    {
        public static int Add(string nums)
        {
            var returnVal = 0;
            if (!String.IsNullOrEmpty(nums))
            {
                returnVal = Int32.Parse(nums);
            }
            
            return returnVal;
        }
    }
}
