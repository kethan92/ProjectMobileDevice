using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobileDevice
{
    class Display
    {
        private string size = null;

        private Nullable<int> numberOfColors;

        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public Nullable<int> NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }

        public Display(string size, Nullable<int> NumberOfColors)
        {
            this.size = size;
            this.NumberOfColors = NumberOfColors;
        }
        // Tostring
        public override string ToString()
        {
            List<string> array = new List<string>();
            if (this.Size!=null)
            {
                array.Add("Size:" + this.Size);
            }
            if (this.NumberOfColors.ToString() != null)
            {
                array.Add("Number Of Colors:" + this.NumberOfColors);
            }
            // return String.Format(array);
            return String.Join(", ", array);

        }
    }
}
