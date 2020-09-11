using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
        }

        private bool isPrime(double number)
        {
            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public double LargestPrimeFactor(double num)
        {
            List<double> primeFactors = new List<double>();
            num = 13195;

            //2 is the first prime number
            double div = 2;

            while (div < num)
            {
                if (num % div == 0)
                {
                    if (primeFactors.Contains(div) == false)
                    {
                        primeFactors.Add(div);
                    }

                    num /= div;
                }
                div++;
            }



            
            return primeFactors.Max();
        }
    }
}
