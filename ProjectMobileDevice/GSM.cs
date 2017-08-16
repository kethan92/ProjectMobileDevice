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
        public string model = null;// mẫu
        public string manufacturer;// Nhà sản xuất
        Nullable<double> prince = null;

        string owner = null;// chủ sở hữu
                            // string battery; đặc tính của pin
        Battery battery;
        Display display;


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
                    throw new Exception("field is not null");
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

        public override string ToString()
        {
            ArrayList array = new ArrayList();
            if (prince.HasValue)
            {
                array.Add(prince);
            }

            if (owner.Length!=0)
            {
                array.Add(owner);
            }
           // array.Add(battery.)
            

            return string.Format("Product detail: Model:{0}\n Manufacturer:{1}\n Prince{2}\n Owner{3}\n");
        }
        
        Battery batter = new Battery(Battery.BatteryType.LiIon,12,12);


        private GSM IPhone4S = new GSM("IPhone4S", "Apple", 13000000, null,
            new Battery(Battery.BatteryType.LiIon, 12, 12), new Display("890x140", 3));


    }
}
