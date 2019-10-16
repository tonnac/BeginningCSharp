using System;

namespace ConsoleApp1
{
    class CallbackArg { }

    class PrimeCallbackArg : CallbackArg
    {
        public int Prime;

        public PrimeCallbackArg(int Prime)
        {
            this.Prime = Prime;
        }
    }

    class PrimeGenerator
    {
        public delegate void PrimeDelegate(object sender, CallbackArg arg);

        PrimeDelegate callbacks;

        public void AddDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Combine(callbacks, callback) as PrimeDelegate;
        }

        public void RemoveDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Remove(callbacks, callback) as PrimeDelegate;
        }

        public void Run(int limit)
        {
            for(int i=2; i<=limit; ++i)
            {
                if(IsPrime(i) == true && callbacks != null)
                {
                    callbacks(this, new PrimeCallbackArg(i));
                }
            }
        }

        private bool IsPrime(int candidate)
        {
            if((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for(int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0) return false;
            }
            return candidate != 1;
        }
    }

    class Program
    {
        static void PrintPrime(object sender, CallbackArg arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime + ", ");
        }

        static int Sum;

        static void SumPrime(object sender, CallbackArg arg)
        {
            Sum += (arg as PrimeCallbackArg).Prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            PrimeGenerator.PrimeDelegate callprint = PrintPrime;
            gen.AddDelegate(callprint);

            PrimeGenerator.PrimeDelegate callsum = SumPrime;
            gen.AddDelegate(callsum);

            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            gen.RemoveDelegate(callsum);
            gen.Run(15);

        }
    }

}