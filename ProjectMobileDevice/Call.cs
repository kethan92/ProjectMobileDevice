using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMobileDevice
{
    class Call
    {
        private long longTime;
        private DateTime date;
        private string dialedPhone;

      

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string DialedPhone
        {
            get
            {
                return dialedPhone;
            }

            set
            {
                dialedPhone = value;
            }
        }

        public long LongTime
        {
            get
            {
                return longTime;
            }

            set
            {
                longTime = value;
            }
        }

        public Call(DateTime date,string dialedPhone,long longTime)
        {
            this.date = date;
            this.dialedPhone = dialedPhone;
            this.LongTime = longTime;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}",this.Date,this.DialedPhone,this.LongTime);
        }
    }
}
