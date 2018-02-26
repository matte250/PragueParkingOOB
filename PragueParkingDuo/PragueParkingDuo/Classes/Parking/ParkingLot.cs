using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingDuo.Classes.Parking
{
    public class ParkingLot
    {
        private ParkingSlot[] parkingslots = new ParkingSlot[100];
        public int getNumFreeParkingSlots { get; private set; }
        public int getLargestFreeSpace { get; private set; }

        public ParkingLot()
        {
            for (int i = 0; i < parkingslots.Length; i++)
            {
                parkingslots[i] = new ParkingSlot();
            }
        }

        public bool TryAddVehicle(Vehicle veh, out int indexOut)
        {
            int i = FindSpace(veh.Size);
            if (i >= 0)
            {
                parkingslots[i].AddVehicle(veh);
                indexOut = i;
                return true;
            }
            indexOut = -1;
            return false;
            // Use the method FindSpace to find a ParkingSlot to instantiate
            // a new vehicle to.

            // Set indexOut to be the returned value of FindSpace().
            // If FindSpace did not return -1, then add a vehicle to the list held by		
            // the ParkingSlot at index of FindSpace.

            // Return true if Vehicle could be added.
            // Return false if Vehicle could not be added.
        }

        public bool TryRemoveVehicle(string reg, out int indexOut)
        {
            int i = Search(reg);
            if (i >= 0)
            {
                parkingslots[i].RemoveVehicle(reg);
                indexOut = i;
                return true;
            }
            else
            {
                indexOut = -1;
            }

            return false;
            //Use the method Search to find the index of a ParkingSlot that contains
            // a vehicle with reg. 

            // Set indexOut to be the returned value of  Search(reg).
            // If Search did not return -1, then remove a vehicle with reg in the list 		
            // held by the ParkingSlot at index of Search.

            // Return true if vehicle was found and removed.
            // Return false if vehicle was not found and not removed.
        }

        public int FindSpace(int size)
        {
            // Find parking index with "size" => FreeSpace, and return the index.
            // If you cannot find a parking with freespace, return -1.

            for (int i = 0; i < parkingslots.Length; i++)
            {
                if (size <= parkingslots[i].FreeSpace) return i;
            }
            return -1;

        }

        public int Search(string reg)
        {
            for (int i = 0; i < parkingslots.Length; i++)
            {
                if(parkingslots[i].ContainsVehicle(reg))
                {
                    return i;
                }
            }
            return -1;
            // Iterate over the array and each list contained in the array. 
            // Check if any vehicle in any of the lists contains reg
            // If it contains the reg return the current position.
            // If reg could not be found, return -1.
        }
        public bool TryMove(string reg, int pIndex)
        {
            // Use the search method to see if reg exists in any of the vehicles
            // of the ParkingSlot list.

            // Use getVehicle(reg).size and compare it to the FreeSpace of ParkingSlot
            // index vehicles list, to see if the move is valid.

            // If the move is valid, remove Vehicle from its current ParkingSlot and add
            // it to the pIndex ParkingSlot.

            // If reg could be found by Search, and move was valid, then return true,  		
            // otherwise return false.
            int index = Search(reg);
            if (index != -1 && pIndex >= 0 && pIndex <= 100)
            {
                int sizeFrom = parkingslots[index].GetVehicle(reg).Size;
                int freeSizeTo = parkingslots[pIndex].FreeSpace;
                if(freeSizeTo >= sizeFrom)
                {
                    Vehicle tempV = parkingslots[index].GetVehicle(reg);
                    parkingslots[index].RemoveVehicle(reg);
                    parkingslots[pIndex].AddVehicle(tempV);
                    return true;
                }
            }
            
            return false;
        }
        
        public ParkingSlot[] Content()
        {
            ParkingSlot[] returnValue = new ParkingSlot[100];

            for (int i = 0; i < parkingslots.Length; i++)
            {
                returnValue[i] = parkingslots[i];
            }
            return returnValue;
        }
    }

}
