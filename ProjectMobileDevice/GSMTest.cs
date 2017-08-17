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
            //  Battery ba = new Battery(Battery.BatteryType.LiIon, 12, null);
            //  Display di = new Display("560x960", null);
            GSM[] gsm = new GSM[]
            {
              new GSM("Zenfone", "ASUS", 2000000, "Nguyen Ke Than",
                new Battery(Battery.BatteryType.LiIon,10,14),
                new Display("460x960",null)),
              new GSM("Zenfone 2", "ASUS", 2000000, "Michale",
                new Battery(Battery.BatteryType.NiCd,11,13),
                new Display("460x960",34)),
              new GSM("IPhone 5", "Apple", 2000000, "Obama",
                new Battery(Battery.BatteryType.LiIon,15,9),
                new Display("460x960",null)),
              new GSM("Sam Sung Galaxy", "SamSung", 2000000, "Ronaldo",
                new Battery(Battery.BatteryType.LiIon,22,14),
                new Display("460x960",null)),
              new GSM("BPhone", "Bkav", 2000000, "Messi",
                new Battery(Battery.BatteryType.NiMH,44,14),
                new Display("460x960",null)),
              new GSM("Nokia", "Microsoft", 30000, "Neymar",
                new Battery(Battery.BatteryType.NiMH,56,14),
                new Display("460x960",null)),
              new GSM("IPhone 5S", "Apple", 2000000, "Van Persi",
                new Battery(Battery.BatteryType.LiIon,14,14),
                new Display("460x960",null)),
              new GSM("IPhone 7S", "Apple", 2000000, "Drogba",
                new Battery(Battery.BatteryType.LiIon,99,33),
                new Display("460x960",null)),
              new GSM("Zenfone", "ASUS", 2000000, "Hazard",
                new Battery(Battery.BatteryType.LiIon,23,14),
                new Display("460x960",null)),
              new GSM("Oppo 7S", "ASUS", 2000000, "Le Cong Vinh",
                new Battery(Battery.BatteryType.LiIon,10,14),
                new Display("460x960",null)),
            };

            foreach(GSM gs in gsm)
            {
                Console.WriteLine(gs);
            }

            //GSM.IPhone4S.ToString();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("---------------IPHONE4S---------------------");
            GSM.IPhone4S1.ToString();


            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            GSM gsms = new GSM("SamSungGalaxyNote7", "SangSum", 40000, "Michale",
                new Battery(Battery.BatteryType.NiCd, 144, 23),
                new Display("444x888", 123));

            //gsms.CallHistory.Add(new Call(new DateTime(2017,3,3), "0984753625", 120));
          //  List<Call> call
            Call call = new Call(DateTime.Now, "0984437584", 120);
            gsms.AddCall(call);
            gsms.AddCall(new Call(DateTime.Now, "0193847438", 134));
            gsms.AddCall(new Call(DateTime.Now, "0133824738", 124));
            gsms.printCall();

            //prince call
            Console.WriteLine("Total prince of the call in history:{0} ", gsms.caculatePrinceCall(0.37));




            // get longtime call
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("-----------Remove the longest call from the history -------------");
            gsms.DeleteLongCall();           
            gsms.printCall();
            Console.WriteLine("Total prince of the call in history:{0} ", gsms.caculatePrinceCall(0.37));


            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("--------------------clear the call history ----------------------------");
            gsms.ClearCall();
            gsms.printCall();


            // gsms.Add(new Call(new DateTime(2017,3,3),"0984753625",120));
           
               
            Console.ReadKey();
        }
    }
}
