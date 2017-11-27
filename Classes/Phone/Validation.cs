using System;

namespace Phone
{
    public static class Validation
    {
        public static void StringValidation(string toValid)
        {
            if (toValid == null)
            {
                throw new ArgumentNullException("String is Null");
            }
        }

        public static void IsIntMoreThanZero(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Number is less or equals zero");
            }
        }

        public static void IsIntMoreThanZero(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Number is less or equals zero");
            }
        }

        public static void IsIntLessThanZero(double price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Number is less than zero");
            }
        }

        public static void IsIntLessThanZero(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Number is less or equals zero");
            }
        }
    }
}
