using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_19GSM
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM myPhone = new GSM("Samsung",
                340.50m,
                new Battery(Battery.BatteryModel.LiIon, 150),
                new TelephoneScreen(15.2d, "16.5M"),
                "Samsung",
                "Zhivko Milev");

            Console.WriteLine(myPhone.ToString());

            myPhone.AddCall(DateTime.Now.ToString(), DateTime.Now.TimeOfDay.ToString(), 40);
            myPhone.AddCall("09-06-2015", DateTime.Now.TimeOfDay.ToString(), 30);

            Console.WriteLine("{0}", myPhone.CallHistory[0].ToString());

            Console.WriteLine("Total bill: {0} ", myPhone.CalculateBill(0.37m));

            myPhone.DeleteCall(myPhone.CallHistory.Max());

            foreach (Call call in myPhone.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }

            myPhone.DeleteCallHistory();

            foreach (Call call in myPhone.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
        }
    }
}
