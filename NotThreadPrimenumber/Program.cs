using System;

namespace NotThreadPrimenumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("입력 ");

            while (true)
            {
                Console.WriteLine("입력.");
                string userNumber = Console.ReadLine();

                if (userNumber.Equals("x", StringComparison.OrdinalIgnoreCase) == true)
                {
                    Console.WriteLine("종료");
                    break;
                }

                CountPrimeNumbers(userNumber);
            }
        }

        private static void CountPrimeNumbers(object initialValue)
        {
            string value = (string)initialValue;
            int primeCandidate = int.Parse(value);

            int totalPrimes = 0;

            for (int i = 2; i < primeCandidate; ++i)
            {
                if (IsPrime(i) == true)
                {
                    totalPrimes++;
                }
            }
            Console.WriteLine("개수 : {0}", totalPrimes);
        }

        private static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0) return false;
            }

            return candidate != 1;
        }
    }
}