using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_data
{
    class employeedata
    {
        static void Main()
        {
            string firstname;
            string lastname;
            sbyte age;
            char gender;
            int IDnumber;
            int unique_empl_number;
            Console.WriteLine("Enter First Name: ");

            firstname=Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            lastname = Console.ReadLine();
            
            Console.WriteLine("Enter age: ");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Enter gender, M or F: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter IDnumber: ");
            IDnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter unique employee number: ");
            unique_empl_number = int.Parse(Console.ReadLine());

        }
    }
}
