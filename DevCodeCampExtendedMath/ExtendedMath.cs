using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCodeCampExtendedMath
{
    public static class ExtendedMath
    {
        public static List<int> GetHappyNums(int nums)
        {
                    
            List<int> happyNumbers = new List<int>();
            int checkAgainst = 1;
        
            while (happyNumbers.Count < nums)
            {
                if (CheckHappyNumbers(checkAgainst))
                {
                    happyNumbers.Add(checkAgainst);
                    checkAgainst += 1;
                }else
                {
                    checkAgainst += 1;
                }
            }
            return happyNumbers;
        }

 
        public static int AddPowers(int num)
        {
            int sum = 0;
            char[] splitToDigits = num.ToString().ToCharArray();
            foreach(char number in splitToDigits)
            {
                int val = int.Parse(number.ToString());
                sum += (val * val);
            }
            return sum;

        }

        public static bool CheckHappyNumbers(int number)
        {
            List<int> copyList = new List<int>();
            bool find = true;
            while (find)
            {
                int result = AddPowers(number);
                if (result == 1)
                {
                    return true;
                }
                else if (copyList.Contains(result))
                {
                    return false;
                }
                else
                {
                    number = result;
                    copyList.Add(result);
                }   
            }
            return false;



        }
    }
}