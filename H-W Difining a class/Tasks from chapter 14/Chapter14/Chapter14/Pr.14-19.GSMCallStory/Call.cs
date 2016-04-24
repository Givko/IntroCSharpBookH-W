using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._14_19.GSMCallStory
{
    public class Call : IComparable
    {
        private string date;
        private string time;
        private int duration;


        public Call(string date, string time, int duration)
        {
            this.date = date;
            this.time = time;
            this.duration = duration;
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public int CompareTo(object obj)
        {
            Call toBeComapredTo = obj as Call;
            if (this.Duration > toBeComapredTo.Duration)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(date + " ");
            sb.Append(time.ToString() + " ");
            sb.Append(duration );
            return sb.ToString();
        }
    }
}
