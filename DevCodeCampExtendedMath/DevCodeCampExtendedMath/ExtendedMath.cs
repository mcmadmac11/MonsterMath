using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCodeCampExtendedMath
{
    static class ExtendedMath
    {
        public static List<int> FindHappies(int superHappyNums)
        {
                    
            List<int> happyNumbers = new List<int>();
            int checkAgainst = 1;
        
            while (happyNumbers.Count < superHappyNums)
            {
                if (FindHappies(checkAgainst))
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

        private static bool FindHappies(int number)
        {
            
        }
        private static int AddPowers(int num)
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





    }
}