using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_19GSM
{
    class GSM
    {
        private static GSM nokia95 = new GSM("Nokia95",
            150.5M, new Battery(Battery.BatteryModel.LiIon, 8, "15h"), new TelephoneScreen(3.3F, "16.5M"), "Nokia");
        private decimal price;

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public TelephoneScreen Screen { get; set; }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price must positive!!");
                }

                this.price = value;
            }
        }
        public List<Call> CallHistory { get; set; }

        public static string ShowNokia95Info()
        {
            return GSM.nokia95.ToString();
        }

        public GSM(string model, decimal price, Battery battery, TelephoneScreen screen)
            : this(model, price, battery, screen, null, null)
        {

        }

        public GSM(string model, decimal price, Battery battery, TelephoneScreen screen, string manufacturer)
            : this(model, price, battery, screen, manufacturer, null)
        {

        }

        public GSM(string model, decimal price, Battery battery, TelephoneScreen screen, string manufacturer, string owner)
        {
            this.Model = model;
            this.Price = price;
            this.Battery = battery;
            this.Screen = screen;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.CallHistory = new List<Call>();
        }

        public override string ToString()
        {
            StringBuilder phoneInfo = new StringBuilder(string.Format("Model: {0} {1}Price: {2:C} {1}Battery:{1}{3} {1}Screen:{1}{4} {1}",
                this.Model, Environment.NewLine, this.Price, this.Battery.ToString(), this.Screen.ToString()));

            if (!String.IsNullOrEmpty(this.Manufacturer))
            {
                phoneInfo.Append(string.Format("Manufacturer: {0}{1}", this.Manufacturer, Environment.NewLine));
            }
            if (!String.IsNullOrEmpty(this.Owner))
            {
                phoneInfo.Append(string.Format("Owner: {0}{1}", this.Owner, Environment.NewLine));
            }

            return phoneInfo.ToString();
        }

        public void AddCall(string date, string time, uint duration)
        {
            this.CallHistory.Add(new Call(date, time, duration));
        }

        public void DeleteCall(Call callToRemove)
        {
            this.CallHistory.Remove(callToRemove);
        }

        public void DeleteCallHistory()
        {
            this.CallHistory.Clear();
        }

        public string CalculateBill(decimal pricePerMinute)
        {
            decimal bill = 0;

            foreach (var call in this.CallHistory)
            {
                bill += call.Duration * pricePerMinute;
            }

            return String.Format("{0:C}", bill);
        }
    }
}
