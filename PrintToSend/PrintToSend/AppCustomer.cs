using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintToSend
{
    class AppCustomer
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public AppCustomer()
        { }
        public AppCustomer(string Number, string Name)
        {
            this.Number = Number;
            this.Name = Name;
        }
    }
}
