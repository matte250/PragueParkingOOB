using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingDuo.Classes.Parking
{
    public class ParkingSlot
    {


        private static int size = 4;
        public int FreeSpace { get; private set; } = size;
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle veh)
        {
            // Compare veh.Size and FreeSpace.
            // If there is space, Add veh to vehicles, and substract Size from FreeSpace.
            // If there is no space, throw an overflow exception.

            if(veh.Size <= FreeSpace)
            {
                vehicles.Add(veh);
                FreeSpace = FreeSpace - veh.Size;
            }
            else
            {
                 throw new OverflowException();
            }
        }

        public void RemoveVehicle(string reg)
        {
            // Look if reg exists in list vehicles.
            // If it does, remove from list, and add removed vehicle size to FreeSpace.

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Reg.Contains(reg))
                {
                    vehicles.RemoveAt(i);
                    FreeSpace = FreeSpace + vehicles[i].Size;
                }
            }
        }

        public List<Vehicle> Content()
        {
            List<Vehicle> vl = new List<Vehicle>();
            foreach(Vehicle v in vehicles)
            {
                vl.Add(v.VehicleClone());
            }
            return vl;
        }
    }

}
