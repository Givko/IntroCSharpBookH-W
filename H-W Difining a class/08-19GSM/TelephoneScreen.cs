using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_19GSM
{
    class TelephoneScreen
    {
        private double? diagonal;
        public double? Diagonal
        {
            get
            {
                return this.diagonal;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be a positive number.");
                }
                this.diagonal = value;
            }
        }
        public string Colors { get; set; }

        public override string ToString()
        {
            return new StringBuilder(string.Format("  Diagonal: {0}{1}  Colors: {2}", this.Diagonal, Environment.NewLine, this.Colors)).ToString();
        }

        public TelephoneScreen(double diagonal, string colors)
        {
            this.Diagonal = diagonal;
            this.Colors = colors;
        }
    }
}
