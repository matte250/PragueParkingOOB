using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingDuo.Classes
{
    public class Car : Vehicle
    {		
        public Car(string reg) : base(reg)
        {
            this.Size = 4;
        }

        public Car() : base()
        {

        }

    }

}
