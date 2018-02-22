using System;

namespace StringCalc.Core
{
    public class Methods
    {
        public static int Add(string nums)
        {
            var returnVal = 0;

            if (!String.IsNullOrEmpty(nums))
            {
                nums = nums.Replace("\n", ",");

                foreach (var num in nums.Split(','))
                {
                    returnVal += int.Parse(num);
                }
                
            }
            
            return returnVal;
        }
    }
}
