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
          
            Vehicle veh = null;

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Reg.Contains(reg))
                {

                    veh = vehicles[i];
                    FreeSpace = FreeSpace + vehicles[i].Size;
                    break;

                }
            }

            if (veh != null) vehicles.Remove(veh);
            //foreach(Vehicle v in vehicles)
            //{
            //    if (v.Reg == (reg))
            //    {

            //        FreeSpace = FreeSpace + v.Size;
            //        vehicles.Remove(v);
            //    }
            //}
        }

        public bool ContainsVehicle(String reg)
        {
            // Loop through each Vehicle in the list vehicles and return true if Vehicle with reg was found, else false.
            foreach(Vehicle v in vehicles)
            {
                if (v.Reg.Equals(reg)) return true;
            }
            return false;
        }

        public Vehicle GetVehicle(string reg)
        {
            // If reg exists, then return a copy of that vehicle.
            if (ContainsVehicle(reg))
            {
                foreach(Vehicle v in vehicles)
                {
                    if (v.Reg.Equals(reg)) return v.Clone();
                }
            }

            return null;
        }

        public ParkingSlot Clone()
        {
            ParkingSlot temp = new ParkingSlot();
            foreach (Vehicle v in vehicles)
            {
                temp.AddVehicle(v.Clone());
            }
            return temp;
        }

        public List<Vehicle> GetVehicles()
        {
            List<Vehicle> vl = new List<Vehicle>();
            foreach (Vehicle v in vehicles)
            {
                vl.Add(v);
            }
            return vl;
        }
    }

}
