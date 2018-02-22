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
                char delimiter = GetAndCleanDelimiter(ref nums);

                nums = RemoveNewLines(nums);
                returnVal = SumMyNums(nums, delimiter);
            }

            return returnVal;
        }

        private static char GetAndCleanDelimiter(ref string nums)
        {
            var delimiter = ',';
            if (nums.Length > 4 && nums.Substring(0, 2) == "//")
            {
                delimiter = nums.Substring(2, 1).Take(1).First();
                nums = nums.Remove(0, 4);
            }

            return delimiter;
        }

        private static int SumMyNums(string nums, char delimiter)
        {
            var returnVal = 0;
            var negNumsDetected = 0;
            var negNumsFound = "";

            foreach (var num in nums.Split(delimiter))
            {
                var currentNum = int.Parse(num);

                if (currentNum < 0)
                {
                    negNumsFound = $"{num}, ";
                    negNumsDetected++;
                }
                else
                {
                    returnVal += currentNum;
                }
                
            };
            if (negNumsDetected > 0)
            {
                throw new ArgumentException($"There are {negNumsDetected} negative numbers detected: {negNumsFound}");
            }
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
