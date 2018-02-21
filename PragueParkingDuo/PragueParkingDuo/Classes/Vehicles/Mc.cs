using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingDuo.Classes
{
    public class Mc : Vehicle
    {
        public Mc(string reg) : base(reg)
        {
            this.Size = 2;
        }

        public Mc() : base()
        {

        }

    }

}
