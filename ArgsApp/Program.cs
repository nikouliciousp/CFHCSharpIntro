using System;

namespace ArgsApp
{
    /// <summary>
    /// A simple console application that prints out the command line arguments.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: ArgsApp <arg1> <arg2> <arg3>");
                Environment.Exit(1);
            }

            Console.WriteLine($"Arg1: {args[0]}, Arg2: {args[1]}, Arg3: {args[2]}");
        }
    }
}
