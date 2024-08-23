namespace LeedCodeProblems.Tools
{
    public class Gcd
    {
        public static int BinaryGcd(int a, int b)
        {
            int shift;
            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            for (shift = 0; ((a | b) & 1) == 0; ++shift)
            {
                a >>= 1;
                b >>= 1;
            }
            while ((a & 1) == 0)
            {
                a >>= 1;
            }

            do
            {
                while ((b & 1) == 0)
                {
                    b >>= 1;
                }

                if (a > b)
                {
                    (a, b) = (b, a);
                }
                b = b - a;
            } while (b != 0);

            return a << shift;
        }
    }
}

