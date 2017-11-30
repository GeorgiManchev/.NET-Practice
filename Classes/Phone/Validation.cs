using System;

namespace Phone
{
    public static class Validation
    {
        public static string StringValidation(this string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("Text must have a value");
            }

            return text;
        }

        public static double IsPositive(this double num)
        {
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException("Number must be positive");
            }

            return num;
        }

        public static int IsPositive(this int num)
        {
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException("Number must be positive");
            }

            return num;
        }

        public static double IsNegative(this double num)
        {
            if (num >= 0)
            {
                throw new ArgumentOutOfRangeException("Number must be negative");
            }

            return num;
        }

        public static int IsNegative(this int num)
        {
            if (num >= 0)
            {
                throw new ArgumentOutOfRangeException("Number must be negative");
            }
            
            return num;
        }
    }
}