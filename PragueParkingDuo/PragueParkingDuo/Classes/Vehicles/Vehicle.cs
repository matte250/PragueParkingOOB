using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingDuo.Classes
{
    public class Vehicle
    {
        public int Size { get; set; }
        public string Reg { get; private set; }
        public DateTime Arrival { get; private set; }

        public Vehicle()
        {
            Arrival = DateTime.Now;
        }
        public Vehicle(string reg)
        {
            Reg = reg;
            Arrival = DateTime.Now;
        }

        public Vehicle Clone()
        {
            return (Vehicle)Activator.CreateInstance(GetType(), Reg);
        }

        public override string ToString()
        {
            return "V:" + Reg;
        }

    }

}
