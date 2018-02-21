using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingDuo.Classes
{
    public class Bike : Vehicle
    {
        public Bike(string reg) : base(reg)
        {
            this.Size = 1;
        }

        public Bike() : base()
        {
            this.Size = 1;
        }

    }

}
