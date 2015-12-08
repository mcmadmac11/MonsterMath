using System;
using System.Collections.Generic;
using System.Linq;
using DevCodeCampExtendedMath;



namespace DevCodeCampExtendedMath
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> happyNumbers = DevCodeCampExtendedMath.ExtendedMath.GetHappyNums(51);

            for (int i = 0; i < happyNumbers.Count; i++)
            {
                Console.WriteLine( i + ":" +(happyNumbers[i]));
            }

            {
               
            }

        }
    }
}
