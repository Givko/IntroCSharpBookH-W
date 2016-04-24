using System;
using System.Text;

namespace _08_19GSM
{
    class Call : IComparable
    {
        public string CallDate { get; set; }
        public string StartTime { get; set; }
        public uint Duration { get; set; }

        public Call(string date,string time,uint duration)
        {
            this.CallDate = date;
            this.StartTime = time;
            this.Duration = duration;
        }
        public override string ToString()
        {
            StringBuilder call = new StringBuilder(string.Format("Date: {0}{1}Time: {2}{1}Duration: {3}",
                this.CallDate,Environment.NewLine,this.StartTime,this.Duration));

            return call.ToString();
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
    }
}
