using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._14_19.GSMCallStory
{
    class Program
    {
        static StringBuilder result = new StringBuilder();
        static GSM ourPhone = GSM.NokiaN95;
        static void Main(string[] args)
        {
            ReadInput();
            PrintOutput();   
        }
        static void ReadInput()
        {
            string line = Console.ReadLine();
            while (line != "End.")
            {
                string[] separators = { ",", "(", ")", " " };
                string[] arguments = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < arguments.Length; i++)
                {
                    arguments[i] = arguments[i].Trim();
                }
                ComandExecutes(arguments);
                line = Console.ReadLine();
            }
        }
        private static void ComandExecutes(string[] arguments)
        {
            switch (arguments[0])
            {
                case "AddCall":
                    {
                            ourPhone.AddCall(arguments[1], arguments[2], int.Parse(arguments[3]));
                            result.Append("Call added." + System.Environment.NewLine);
                       
                        break;
                    }
                case "DeleteCall":
                    {
                        ourPhone.ClearCallHistory();
                        result.Append("Call history deleted." + System.Environment.NewLine);
                        break;
                    }
                case "CalculateSum":
                    {
                        result.Append(ourPhone.CalculateBill(double.Parse(arguments[1])).ToString() + System.Environment.NewLine);
                        break;
                    }
                case "DeleteMostExpensiveCall":
                    {
                         List<Call> calls = ourPhone.CallHistory;
                         Call maxCall = calls.Max();
                         calls.Remove(maxCall);
                        result.Append("Most expensive call deleted." + System.Environment.NewLine);
                        break;
                    }
                case "PrintCallHistory":
                    { 
                        if(ourPhone.CallHistory.Count>0)
                        {
                            foreach (var item in ourPhone.CallHistory)
                            {
                                result.Append(item.ToString() + System.Environment.NewLine);
                            }
                        }
                        else
                        {
                            result.Append("No calls." + System.Environment.NewLine);
                        }
                        break;
                    }
                default:
                    {
                        result.Append("Invalid Comand." + System.Environment.NewLine);
                        break;
                    }

            }
        }
        static void PrintOutput()
        {
            Console.WriteLine(result);
        }
    }  
}

