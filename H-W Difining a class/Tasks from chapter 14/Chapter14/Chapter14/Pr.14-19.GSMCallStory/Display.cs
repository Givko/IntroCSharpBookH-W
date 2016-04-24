using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._14_19.GSMCallStory
{
    public class Display
    {
        private double? displaySize;
        private int? displayColors;

        public Display()
        {
            this.displaySize = null;
            this.displayColors = null;
        }

        public Display(double displaySize, int displayColors)
        {
            // TODO: Complete member initialization
            this.displaySize = displaySize;
            this.displayColors = displayColors;
        }
        public override string ToString()
        {
            return string.Format("displaySize: {0}, displayColors: {1}", displaySize, displayColors);
        }
    }
}
