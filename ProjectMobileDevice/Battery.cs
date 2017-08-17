using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectMobileDevice
{
    class Battery
    {
        // create enum GSM
        public enum BatteryType { LiIon, NiMH, NiCd }
        BatteryType model;
        private Nullable<int> hoursIdle=null;
        private Nullable<int> hoursTalk=null;

        public Nullable<int> HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }

        }
        
        public Nullable<int> HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }

        }
          
        // public BatteryType Model { get; set; }
        public Battery(BatteryType model, Nullable<int> hoursIdle=null, Nullable<int> hoursTalk=null)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        // Tostring
        public override string ToString()
        {
            Console.WriteLine("BATTERY");
            if(this.HoursIdle.HasValue)
            {
                Console.WriteLine("Hours Idle: "+this.HoursIdle);
            }
            if (this.HoursTalk.HasValue)
            {
                Console.WriteLine("Hours Talk: " + this.HoursTalk);
            }
            return string.Format("Model: " + this.model);
            /*
            List<string> array = new List<string>();
            array.Add("Model:" + this.model);
            if (this.HoursIdle.HasValue)
            {
                array.Add("Hour idle:"+this.HoursIdle);
            }
            if (this.HoursTalk.HasValue)
            {
                array.Add("Hour talk:"+this.HoursTalk);
            }
           // return String.Format(array);
            return String.Join(", ", array);
            */

        }

    }
}
