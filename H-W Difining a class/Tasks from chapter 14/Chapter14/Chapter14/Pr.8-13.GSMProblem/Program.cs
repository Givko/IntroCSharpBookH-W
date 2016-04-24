using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSMProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<GSM> phones = new List<GSM>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                if (line == "Nokia95")
                {
                    phones.Add(GSM.NokiaN95);
                }
                else
                {
                    string[] arguments = line.Split(';');
                    if (arguments.Count() == 4)
                    {
                        GSM newPhone = new GSM(arguments[0], arguments[1], double.Parse(arguments[2]), arguments[3]);
                        phones.Add(newPhone);
                    }
                    else
                    {
                        GSM newPhone = new GSM(arguments[0], arguments[1], double.Parse(arguments[2]), arguments[3], arguments[4], int.Parse(arguments[5]), int.Parse(arguments[6]), double.Parse(arguments[7]), int.Parse(arguments[8]));
                        phones.Add(newPhone);
                    }
                }
            }

            foreach (GSM phone in phones)
            {
                Console.WriteLine(phone);
            }
        }
    }

    public class GSM
    {
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;


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

    }

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
