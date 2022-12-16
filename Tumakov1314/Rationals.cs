using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov1314
{
    [DeveloperInfoAttribute("AkhmetzyanovKamil", "16.12.2022")]
    class Rationals
    {
        public int numerator;
        public int denominator;

        public Rationals()
        {

        }
        public Rationals(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override bool Equals(object obj)
        {

            if (obj is Rationals)
            {
                Rationals rational_number = obj as Rationals;
                return rational_number.numerator == numerator && rational_number.denominator == denominator;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Знаменатель:{numerator} Числитель: {denominator}";
        }

        public static bool operator ==(Rationals R1, Rationals R2)
        {
            if ((R1.numerator == R2.numerator) && (R1.denominator == R2.denominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Rationals R1, Rationals R2)
        {
            if ((R1.numerator != R2.numerator) && (R1.denominator != R2.denominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int NOZ(int d1, int d2)
        {
            int d3;
            if ((d2 >= d1) && (d2 % d1 == 0))
            {
                d3 = d2;
                return d3;
            }
            else if ((d1 > d2) && (d1 % d2 == 0))
            {
                d3 = d1;
                return d3;
            }
            else
                d3 = d2 * d1;
            return d3;
        }

        public static Rationals operator +(Rationals R1, Rationals R2)
        {
            try
            {
                Rationals R3 = new Rationals();
                if (R1.denominator == R2.denominator)
                {
                    R3.numerator = R1.numerator + R1.numerator;
                    R3.denominator = R1.denominator = R2.denominator;
                }
                else if (R1.denominator != R2.denominator)
                {
                    R3.denominator = NOZ(R1.denominator, R2.denominator);
                    R3.numerator = (R1.numerator * (NOZ(R1.denominator, R2.denominator) / R2.denominator) + R2.numerator * (NOZ(R1.denominator, R2.denominator) / R1.denominator));
                    return R3;
                }
                return R3;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Знаменатель не равен нулю!");
            }

        }

        public static Rationals operator -(Rationals R1, Rationals R2)
        {
            Rationals R3 = new Rationals();
            if (R1.denominator == R2.denominator)
            {
                R3.numerator = R1.numerator - R1.numerator;
                R3.denominator = R1.denominator = R2.denominator;
            }
            else if (R1.denominator != R2.denominator)
            {
                R3.denominator = NOZ(R1.denominator, R2.denominator);
                R3.numerator = (R1.numerator * (NOZ(R1.denominator, R2.denominator) / R2.denominator) - R2.numerator * (NOZ(R1.denominator, R2.denominator) / R1.denominator));
                return R3;
            }
            return R3;
        }
        public static bool operator <(Rationals num_1, Rationals num_2)
        {
            if ((num_1.numerator * num_2.denominator) / (num_2.numerator * num_1.denominator) < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Rationals num_1, Rationals num_2)
        {
            if ((num_1.numerator * num_2.denominator) / (num_2.numerator * num_1.denominator) > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Rationals num_1, Rationals num_2)
        {
            if ((num_1.numerator * num_2.denominator) / (num_2.numerator * num_1.denominator) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Rationals num_1, Rationals num_2)
        {
            if ((num_1.numerator * num_2.denominator) / (num_2.numerator * num_1.denominator) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
