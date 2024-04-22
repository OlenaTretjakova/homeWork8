using System;
using System.Text;

namespace homeWork
{
    internal struct Decimal
    {
        public int LeftPart;
        public int RightPart;

        public Decimal(int leftPart, int rightPart)
        {
            LeftPart = leftPart;
            RightPart = rightPart;
        }

        public string Binary()
        {
            string Left = Convert.ToString(LeftPart, 2);

            StringBuilder Right = new StringBuilder();
            Right.Append(".");

            int fraction = RightPart;
            int precision = 32;

            while (fraction != 0 && precision-- > 0)
            {
                fraction *= 2;

                if (fraction >= 1)
                {
                    Right.Append("1");
                    fraction -= 1;
                }
                else
                {
                    Right.Append("0");
                }
            }

            return Left + Right.ToString();
        }
        public  string ToString()
        {
            return LeftPart.ToString() + "," + RightPart.ToString();
        }
    }
}

