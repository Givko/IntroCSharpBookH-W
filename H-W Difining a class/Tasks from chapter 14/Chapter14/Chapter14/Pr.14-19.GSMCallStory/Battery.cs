using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._14_19.GSMCallStory
{
    public class Battery
    {
        private int? hoursIdle;
        private int? hoursTalk;
        private string batteryModel;
        private BatteryType battery;
        enum BatteryType { LiIon, NiMH, NiCD };

        public Battery()
        {
            // TODO: Complete member initialization
            this.batteryModel = null;
            this.hoursIdle = null;
            this.hoursTalk = null;
            this.battery = BatteryType.LiIon;
        }
        public Battery(string batteryModel, int hoursIdle, int hoursTalk)
        {
            // TODO: Complete member initialization
            this.batteryModel = batteryModel;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public override string ToString()
        {
            return string.Format("hoursIdle: {0}, hoursTalk: {1}, batteryModel: {2}", hoursIdle, hoursTalk, batteryModel);
        }
    }
}
