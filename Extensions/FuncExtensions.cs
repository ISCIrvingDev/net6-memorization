using System.Collections.Concurrent;

namespace Extensions
{
    public static class FuncExtensions
    {
        public static Func<T, TResult> Memorize<T, TResult>(this Func<T, TResult> function)
        {
            // Usamos un diccionario de datos para almacenar la informacion que ya tenemos
            var cache = new ConcurrentDictionary<T, TResult>();

            return (a) => cache.GetOrAdd(a, function);
        }
    }
}