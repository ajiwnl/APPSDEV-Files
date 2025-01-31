using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_Calculator
{
    internal class FractionOpt
    {
     public int num, denom;

        public FractionOpt(int num, int denom)
        {
            if (denom == 0) {
                throw new ArgumentException("Denominator cannot be zero");
            }
            this.num = num;
            this.denom = denom;
        }

        public FractionOpt Add(FractionOpt other)
        {
            int lcm = Lcm(this.denom, other.denom);
            int numeratorSum = this.num * (lcm / this.denom) + other.num * (lcm / other.denom);
            return new FractionOpt(numeratorSum, lcm);
        }

        public FractionOpt Subtract(FractionOpt other) {
            int lcm = Lcm(this.denom, other.denom);
            int numeratorDiff = this.num * (lcm / this.denom) - other.num * (lcm / other.denom);
            return new FractionOpt(numeratorDiff, lcm);
        }

        public FractionOpt Multiply(FractionOpt other)
        {
            int numeratorProd = this.num * other.num;
            int denomProd = this.denom * other.denom;
            return new FractionOpt(numeratorProd, denomProd);
        }

        public FractionOpt Divide(FractionOpt other)
        {
            if (other.denom == 0) { 
            throw new ArgumentException("Cannot be divide by zero");
            }
            int numeratorQuo = this.num * other.denom;
            int denomQuo = this.denom * other.num;
            return new FractionOpt(numeratorQuo, denomQuo);
        }

        public string Simplified()
        {
            int gcd = Gcd(this.num, this.denom);
            int newNum = this.num / gcd;
            int newDenom = this.denom / gcd;
            return $"{newNum}/{newDenom}";
        }

        public double DecimalConversion() {
            double decimalOutput = 0;
            decimalOutput = (double)this.num /(double)this.denom;
            return decimalOutput;
        }

        public int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Gcd(b, a % b);
        }

        private int Lcm(int a, int b)
        {
            return Math.Abs(a * b) / Gcd(a, b);
        }
    }
}
