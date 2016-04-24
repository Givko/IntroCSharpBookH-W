using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_company_information
{
    class company
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyname = Console.ReadLine();
            Console.Write("Company adress: ");
            string companyadress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phonenumber =Console.ReadLine();
            Console.Write("Enter Fax: ");
            string fax = "(no fax)";
            fax = Console.ReadLine();
            Console.Write("Web site: ");
            string website = Console.ReadLine();
            Console.Write("Manager name: ");
            string managername = Console.ReadLine();
            Console.Write("Manager lastname: ");
            string managerlastname = Console.ReadLine();
            Console.Write("Age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string managerphone = Console.ReadLine();
            Console.WriteLine("{0} \n Adress: {1} \n Tel. {2} \n Fax: {3} \n Web site: {4} \n Manager: {5} {6} (age: {7}, tel.{8})",companyname,companyadress,phonenumber,fax,website,managername,managerlastname,age,managerphone);
        }
    }
}
