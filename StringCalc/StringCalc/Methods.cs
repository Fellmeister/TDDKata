using System;
using System.Linq;

namespace StringCalc.Core
{
    public class Methods
    {
        public static int Add(string nums)
        {
            var returnVal = 0;
            
            if (IsValidNumsString(nums))
            {
                var delimiter = ',';
                if (nums.Length > 4 && nums.Substring(0, 2) == "//")
                {
                    delimiter = nums.Substring(2, 1).Take(1).First();
                    nums = nums.Remove(0, 4);
                }

                nums = RemoveNewLines(nums);
                returnVal = SumMyNums(nums,delimiter);
            }
            
            return returnVal;
        }

        private static int SumMyNums(string nums, char delimiter)
        {
            var returnVal = 0;
            foreach (var num in nums.Split(delimiter))
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
