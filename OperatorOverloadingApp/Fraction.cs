using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingApp
{
    /// <summary>
    /// Represents a fraction with a numerator and a denominator.
    /// </summary>
    internal class Fraction
    {
        public int Num { get; init; }
        public int Den { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fraction"/> class.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="den"></param>
        /// <exception cref="ArgumentException"></exception>
        public Fraction(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
            Num = num;
            Den = den;
        }

        /// <summary>
        /// Operator overloads for the Fraction class.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.Num, a.Den);
        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.Num * b.Den + b.Num * a.Den, a.Den * b.Den);
        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.Num * b.Num, a.Den * b.Den);
        public static Fraction operator /(Fraction a, Fraction b) => new Fraction(a.Num * b.Den, a.Den * b.Num);

        /// <summary>
        /// Returns a string representation of the fraction.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Num}/{Den}";
    }
}
