using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_areaof_rectangle
{
    internal class Calc_Rectangle_Area
    {
        private decimal length;
        public decimal Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    string ErrorMsg = "Please enter a valid length";
                    throw new Exception(ErrorMsg);
                }
                length = value;
            }
        }

        private decimal breadth;
        public decimal Breadth
        {
            get { return breadth; }
            set
            {
                if (value <= 0)
                {
                    string ErrorMsg = "Please enter a valid breadth";
                    throw new Exception(ErrorMsg);
                }
                breadth = value;
            }
        }

        public string RectangleName { get; set; }

        public decimal Area()
        {
            decimal Area = Length * Breadth;
            return Area;
        }


    }
}
