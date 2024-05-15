using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre3
{
    public struct Currency
    {
        private char sign;
        private decimal value;

        public Currency(char sign, decimal value)
        {
            this.sign = sign;
            this.value = value;
        }

        public char Sign
        {
            get { return this.sign; }
            
        }

        public decimal Value
        {
            get { return this.value; }

        }

        public static Currency operator +(Currency a, Currency b)
        {
            return new Currency(a.sign, a.value + b.value);
        }

        public static Currency operator +(Currency a, decimal x)
        {
            return new Currency(a.sign, a.value +x);
        }

        public static Currency operator -(Currency a, Currency b)
        {
            return new Currency(a.sign, a.value - b.value);
        }

        public static Currency operator -(Currency a, decimal x)
        {
            return new Currency(a.sign, a.value - x);
        }
    }

    public class Test {
        public static void Main(string []args) {

            Currency c1 = new Currency('$', 10);
            Currency c2 = new Currency('$', 20);
            Currency total = c1 - c2;
            Currency totalWithShipping = total - 7;
            Console.WriteLine(totalWithShipping.Value);
        }
    }
}