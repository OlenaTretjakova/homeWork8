using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal struct RGBColor
    {
        public int Red;
        public int Green;
        public int Blue;

        public RGBColor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public string ToHex()
        {
            string hex = $"#{Red:X2}{Green:X2}{Blue:X2}";
            return hex;
        }
    }

}
