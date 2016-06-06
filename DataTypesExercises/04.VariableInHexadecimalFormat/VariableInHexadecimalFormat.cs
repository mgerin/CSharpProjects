using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(number, 16);

            Console.WriteLine(decimalNumber);
        }
    }
}
