using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> keyValues = new Dictionary<int, string>();

            keyValues.Add(3, "Hello");
            keyValues.Add(4, "Vay");
             foreach(var item in keyValues)
            {
                Console.WriteLine($"{item.Key}  {item.Value}");
                
            }

        }
    }

}

