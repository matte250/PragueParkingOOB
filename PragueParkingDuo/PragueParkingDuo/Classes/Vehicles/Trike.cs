using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingDuo.Classes
{
    public class Trike : Vehicle
    {
        public Trike(string reg) : base(reg)
        {
            this.Size = 3;
        }

    }

}
