using System;

namespace StringCalc.Core
{
    public class Methods
    {
        public static int Add(string nums)
        {
            var returnVal = 0;
            
            if (IsValidNumsString(nums))
            {
                nums = RemoveNewLines(nums);
                returnVal = SumMyNums(nums);
            }
            
            return returnVal;
        }

        private static int SumMyNums(string nums)
        {
            var returnVal = 0;
            foreach (var num in nums.Split(','))
            {
                returnVal += int.Parse(num);
            };
            return returnVal;
        }

        private static string RemoveNewLines(string nums)
        {
            return nums.Replace("\n", ",");
        }

        private static bool IsValidNumsString(string nums)
        {
            return !String.IsNullOrEmpty(nums);
        }
    }
}
