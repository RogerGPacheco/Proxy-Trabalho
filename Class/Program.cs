using Proxy_Trabalho.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipmentProxy proxy = new EquipmentProxy();
            Console.WriteLine("Data from Proxy: " + proxy.GetData());

            Console.ReadKey();
        }
    }
}
