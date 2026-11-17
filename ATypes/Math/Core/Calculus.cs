namespace ATypes.Math.Core
{
    public class Calculus
    {
        public static double Sqrt(double x, double n)
        {
            if (x == 0)
                return 0;

            if (n == 0)
                return 1;

            if (x < 0 && n % 2 == 0)
                throw new ArgumentException("Negative number, even degree.");

            double xk = x / n;
            double prevX = 0;

            while (prevX != xk)
            {
                prevX = xk;
                xk = ((n - 1) * xk + x / Pow(xk, n - 1)) / n;
            }

            return xk;
        }

        public static double Pow(double x, double n)
        {
            if (n == 0)
                return 1;

            double result = 1;

            while (n > 0)
            {
                if (n % 2 == 1)
                    result *= x;

                x *= x;
                n /= 2;
            }

            return result;
        }
    }
}
