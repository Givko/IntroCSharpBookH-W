using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_19GSM
{
    class Battery
    {
        public enum BatteryModel
        {
            LiIon,NiMH,NiCd
        }
        public BatteryModel Model { get; set; }
        public string IdleTime { get; set; }
        public uint HoursTalk { get; set; }

        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder(string.Format("  Model: {0}{1}  HoursTalk: {2}{1}",this.Model,Environment.NewLine,this.HoursTalk));
            
            if (!String.IsNullOrEmpty(this.IdleTime))
            {
                batteryInfo.Append(string.Format("  Idle Time: {0}",this.IdleTime));
            }

            return batteryInfo.ToString();
        }
        public Battery(BatteryModel model,uint hoursTalk)
            :this(model,hoursTalk,null)
        {

        }
        public Battery(BatteryModel model, uint hoursTalk, string idleTime)
        {
            this.Model = model;
            this.IdleTime = idleTime;
            this.HoursTalk = hoursTalk;
        }
    }
}
