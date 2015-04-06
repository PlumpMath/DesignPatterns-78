using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("About to print a booklet for saloon cars");
            AbstractBookletPrinter saloonBooklet = new SaloonBooklet();
            saloonBooklet.Print();

            Console.WriteLine("About to print a service history booklet");
            AbstractBookletPrinter serviceBooklet = new ServiceHistoryBooklet();
            serviceBooklet.Print();

            Console.Read();
        }
    }
}
