using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintToSend
{
    class AppOwner
    {
        public string Number { get; set; }
        public string IMEI { get; set; }
        public string Name { get; set; }
        public AppOwner()
        { }
        public AppOwner(string Number,string IMEI,string Name)
        {
            this.Number = Number;
            this.IMEI = IMEI;
            this.Name = Name;
        }
    }
}
