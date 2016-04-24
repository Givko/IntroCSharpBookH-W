using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _13DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            string address = Console.ReadLine();
            string fileName = null;
            try
            {
                fileName = address.Substring(address.LastIndexOf('/'), address.Length - address.LastIndexOf('/') - 1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid argument exception!");
            }
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(address, fileName);
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}