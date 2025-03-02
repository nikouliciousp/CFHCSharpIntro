namespace OperatorOverloadingApp
{
    /// <summary>
    /// Represents a fraction with a numerator and a denominator.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create two objects of the Fraction class
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 3);

            // Add the two fractions
            Fraction f3 = f1 + f2;
            Console.WriteLine($"{f1} + {f2} = {f3}");

            // Subtract the two fractions
            Fraction f4 = f1 - f2;
            Console.WriteLine($"{f1} - {f2} = {f4}");

            // Multiply the two fractions
            Fraction f5 = f1 * f2;
            Console.WriteLine($"{f1} * {f2} = {f5}");

            // Divide the two fractions
            Fraction f6 = f1 / f2;
            Console.WriteLine($"{f1} / {f2} = {f6}");

            // Negate a fraction
            Fraction f7 = -f1;
            Console.WriteLine($"-{f1} = {f7}");
        }
    }
}
