using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingDuo.Classes.Parking
{
    public class ParkingSlot
    {

        public int FreeSpace { get; private set; }
        private int size = 4;
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle veh)
        {
            // Compare veh.Size and FreeSpace.
            // If there is space, Add veh to vehicles, and substract Size from   	  
            // FreeSpace.
            // If there is no space, throw an overflow exception.
        }

        public void RemoveVehicle(string reg)
        {
            // Look if reg exists in list vehicles.
            // If it does, remove from list, and add removed vehicle size to FreeSpace.
        }

        public List<Vehicle> Content()
        {
            return new List<Vehicle>(vehicles);
        }
    }

}
