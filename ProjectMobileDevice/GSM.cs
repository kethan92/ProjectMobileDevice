using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectMobileDevice
{
    class GSM
    {
        public string model;// mẫu
        public string manufacturer;// Nhà sản xuất
        Nullable<double> prince = null;

        string owner = null;// chủ sở hữu
                            // string battery; đặc tính của pin
        Battery battery = null;
        Display display = null;
        List<Call> callHistory = new List<Call>();


        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                   // Console.WriteLine("field is not null");
                    throw new Exception();
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("field is not null");
                }
                this.manufacturer = value;
            }
        }

        public Nullable<double> Prince
        {
            get
            {
                return this.prince;
            }
            set
            {

                this.prince = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {

                this.owner = value;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {

                this.display = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {

                this.battery = value;
            }
        }

        internal static GSM IPhone4S1
        {
            get
            {
                return IPhone4S;
            }

            set
            {
                IPhone4S = value;
            }
        }

        public GSM(string Model, string Manufacturer, double Prince, string Owner,
            Battery battery, Display display)
        {

            this.model = Model;
            this.manufacturer = Manufacturer;
            this.prince = Prince;
            this.owner = Owner;
            this.battery = battery;
            this.display = display;
        }

       

        // add call from the call history

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }
        // delete call from the call history

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }
        // clear the call history
        public void ClearCall()
        {
            this.callHistory.Clear();
        }
        // remove call longtime
        public void DeleteLongCall()
        {
            Call call = null;
            double max = 0;
            for (int i = 0; i < callHistory.Count(); i++)
            {
                if (callHistory[i].LongTime > max)
                {
                    call = callHistory[i];
                    max = callHistory[i].LongTime;
                }
            }
            this.callHistory.Remove(call);
        }
        // caculate time in the call history
        public double caculatePrinceCall(double princeMinute)
        {
            double sumTime = 0;
            for (int i = 0; i < callHistory.Count(); i++)
            {
                sumTime += callHistory[i].LongTime;
            }
            return (double)princeMinute * Math.Ceiling(sumTime / 60);

        }

        // print call
        public void printCall()
        {
            for (int i = 0; i < callHistory.Count(); i++)
            {
                Console.WriteLine("----------Call------------");
                Console.WriteLine("Date Time: " + callHistory[i].Date);
                Console.WriteLine("Dialed phone: " + callHistory[i].DialedPhone);
                Console.WriteLine("Duration {0} seconds", callHistory[i].LongTime);
            }
        }

        public override string ToString()
        {
            Console.WriteLine("----------------GSM:-------------");
            Console.WriteLine("Model: " + this.Model);
            Console.WriteLine("Manufacturer: " + this.Manufacturer);
            if (this.Prince.HasValue)
            {
                Console.WriteLine("Prince: " + this.Prince);
            }
            if (this.Owner.Count() != 0)
            {
                Console.WriteLine("Owner: " + this.Owner);
            }
            Console.WriteLine("" + this.Battery);
            Console.WriteLine("" + this.Display);
            return string.Format("");
        }

        //Battery batter = new Battery(Battery.BatteryType.LiIon,12,12);

        private static GSM IPhone4S;
        static GSM()
        {
            IPhone4S1 = new GSM("IPhone4S", "Apple", 130000, "Nguyen Ke Than",
              new Battery(Battery.BatteryType.LiIon, 12, 12), new Display("890x140", 3));
        }
        
           
           

    }
}
