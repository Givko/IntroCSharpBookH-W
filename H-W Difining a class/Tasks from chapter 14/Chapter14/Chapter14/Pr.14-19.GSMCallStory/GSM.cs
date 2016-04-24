using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._14_19.GSMCallStory
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;

        private List<Call> callHistory = new List<Call>();

        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

       

        public static GSM NokiaN95
        {
            get
            {
                return new GSM("nokia95", "nokia", 199.0, "", "coolBatModel", 12, 123, 7.0, 100);
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        //constructors

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery();
            this.display = new Display();
        }

        public GSM(string model, string manufacturer, double price, string owner, string batteryModel, int hoursIdle, int hoursTalk, double displaySize, int displayColors)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery(batteryModel, hoursIdle, hoursTalk);
            this.display = new Display(displaySize, displayColors);
        }

        public override string ToString()
        {
            return string.Format("model: {0}, manufacturer: {1}, price: {2}, owner: {3}, battery: {4}, , display: {5}", model, manufacturer, price, owner, battery, display);
        }

        public void AddCall(string date, string time, int duration)
        {
            //Call newCall = new Call(date, time, duration);
            callHistory.Add(new  Call(date, time, duration));
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        
        public void DeleteCall(Call callToRemove)
        {
            callHistory.Remove(callToRemove);
        }

        public string CalculateBill(double pricePerMinute)
        {
            double bill = 0;
            foreach (Call item in this.callHistory)
            {
                bill = bill + item.Duration * pricePerMinute;
            }
            return String.Format("{0:0.00}", bill);
        }

    }
}
