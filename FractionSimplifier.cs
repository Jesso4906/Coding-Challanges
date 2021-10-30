using System;
//https://edabit.com/challenge/3wT3QcDdfvMR3amjc
namespace EdabitCodingChallanges
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(Simplify("20/40"));
            Console.ReadKey();
        }
        
        public static string Simplify(string str)
        {
            string numerator = string.Empty;
            string denominator = string.Empty;
            bool isD = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '/' && !isD)
                    numerator += str[i].ToString();
                else
                {
                    isD = true;
                }

                if (isD)
                {
                    if(str[i] != '/')
                        denominator += str[i].ToString();
                }
            }

            int j = 1;
            while (j < 10)
            {
                j++;

                if (int.Parse(numerator) % j == 0 && int.Parse(denominator) % j == 0)
                {
                    numerator = (int.Parse(numerator) / j).ToString();  
                    denominator = (int.Parse(denominator) / j).ToString();

                    j = 1;
                }
            }

            if(int.Parse(denominator) == 1)
                return numerator;
            else
                return numerator + '/' + denominator;
        }
    }
}
