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
            Console.WriteLine(p.LargestPrimeFactor(600851475143));
        }

        public double LargestPrimeFactor(double num)
        {
            List<double> primeFactors = new List<double>();

            //2 is the first prime number
            double div = 2;

            while (div < num)
            {
                if (isPrime(div))
                {
                    if (num % div == 0)
                    {
                        if (primeFactors.Contains(div) == false)
                        {
                            primeFactors.Add(div);
                        }
                        num /= div;

                        if (isPrime(num))
                        {
                            primeFactors.Add(num);
                        }
                    }
                }
                div++;
            }

            return primeFactors.Max();
        }

        private bool isPrime(double number)
        {
            if (number == 1)
            {
                return false;
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
    }
}
