using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobileDevice
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            Battery ba = new Battery(Battery.BatteryType.LiIon, null, null);
            // ba.ToString();
            //Console.WriteLine("ban gggggggggggggggggdc da");
            Console.WriteLine(ba);
            Display di = new Display(null, null);
            Console.WriteLine(di);
            Console.ReadKey();
        }
    }
}
