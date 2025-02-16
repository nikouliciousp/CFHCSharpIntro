namespace PrimitivesApp
{
    /// <summary>
    /// This class contains the entry point of the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        static void Main(string[] args)
        {
            // Display the size, minimum, and maximum values of various primitive data types
            Console.WriteLine($"int: {sizeof(int) * 8} bits \tMin: {int.MinValue}\tMax: {int.MaxValue}");
            Console.WriteLine($"uint: {sizeof(uint) * 8} bits \tMin: {uint.MinValue}\tMax: {uint.MaxValue}");
            Console.WriteLine($"long: {sizeof(long) * 8} bits \tMin: {long.MinValue}\tMax: {long.MaxValue}");
            Console.WriteLine($"ulong: {sizeof(ulong) * 8} bits \tMin: {ulong.MinValue}\tMax: {ulong.MaxValue}");
            Console.WriteLine($"short: {sizeof(short) * 8} bits \tMin: {short.MinValue}\tMax: {short.MaxValue}");
            Console.WriteLine($"ushort: {sizeof(ushort) * 8} bits \tMin: {ushort.MinValue}\tMax: {ushort.MaxValue}");
            Console.WriteLine($"byte: {sizeof(byte) * 8} bits \tMin: {byte.MinValue}\tMax: {byte.MaxValue}");
            Console.WriteLine($"sbyte: {sizeof(sbyte) * 8} bits \tMin: {sbyte.MinValue}\tMax: {sbyte.MaxValue}");
            Console.WriteLine($"float: {sizeof(float) * 8} bits \tMin: {float.MinValue}\tMax: {float.MaxValue}");
            Console.WriteLine($"double: {sizeof(double) * 8} bits \tMin: {double.MinValue}\tMax: {double.MaxValue}");
            Console.WriteLine($"decimal: {sizeof(decimal) * 8} bits \tMin: {decimal.MinValue}\tMax: {decimal.MaxValue}");
            Console.WriteLine($"char: {sizeof(char) * 8} bits \tMin: {char.MinValue}\tMax: {char.MaxValue}");
            Console.WriteLine($"bool: {sizeof(bool) * 8} bits \tFalse: {bool.FalseString}\tTrue: {bool.TrueString}");
            Console.WriteLine($"DateTime: {sizeof(long) * 8} bits \tMin: {DateTime.MinValue}\tMax: {DateTime.MaxValue}");
            Console.WriteLine($"TimeSpan: {sizeof(long) * 8} bits \tMin: {TimeSpan.MinValue}\tMax: {TimeSpan.MaxValue}");
        }
    }
}
