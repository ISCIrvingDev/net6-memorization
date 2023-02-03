using Memorization.Services;
using System.Diagnostics;

namespace Memorization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var memorizationService = new MemorizationService();

                // WithoutMemorization
            var stopWatchWithoutMemorization = Stopwatch.StartNew();

            memorizationService.WithoutMemorization();

            Console.WriteLine("Tiempo en milisegundos sin memorizacion: " + stopWatchWithoutMemorization.ElapsedMilliseconds);
            Console.WriteLine();

                // WithMemorization
            var stopWatchWithMemorization = Stopwatch.StartNew();

            memorizationService.WithMemorization();

            Console.WriteLine("Tiempo en milisegundos con memorizacion: " + stopWatchWithMemorization.ElapsedMilliseconds);
        }
    }
}