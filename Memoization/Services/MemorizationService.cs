using Extensions;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Memorization.Services
{
    public class MemorizationService
    {
        public void WithoutMemorization()
        {
            Func<long, long> factorial = null;
            factorial = n => n > 1 ? n * factorial(n - 1) : n;

            Console.WriteLine("Factorial de 9: " + factorial(9));

            for (int i = 0; i < 10000000; i++)
            {
                factorial(9);
            }
        }

        public void WithMemorization()
        {
            Func<long, long> factorial = null;
            factorial = n => n > 1 ? n * factorial(n - 1) : n;

            var factorialWithMemorization = factorial.Memorize();

            Console.WriteLine("Factorial de 9: " + factorialWithMemorization(9));

            for (int i = 0; i < 10000000; i++)
            {
                factorialWithMemorization(9);
            }
        }
    }
}
