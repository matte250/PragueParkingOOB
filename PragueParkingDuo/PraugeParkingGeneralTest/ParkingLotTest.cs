using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PragueParkingDuo.Classes.Parking;
using PragueParkingDuo.Classes;

namespace PraugeParkingGeneralTest
{
    [TestClass]
    public class ParkingLotTest
    {
        /*
         *  TryAddVehicle testing.
         */
        [TestMethod]
        public void TryAddVehicle_AddedVehicleInEmptyLot_IsTrue()
        {
            // Assign
            ParkingLot testLot = new ParkingLot();
            ParkingSlot testSlot;
            Car testCar = new Car("ABC123");
            // Act
            testLot.TryAddVehicle(testCar, out int temp);
            testSlot = (ParkingSlot)testLot.Content().GetValue(0);
            // Assert
            Assert.IsTrue(testSlot.Content().Contains(testCar));
        }

        [TestMethod]
        public void TryAddVehicle_AddedVehiclesToPartialyFullLot_IsTrue()
        {
            // Assign
            ParkingLot testLot = new ParkingLot();
            ParkingSlot[] testSlots = new ParkingSlot[4];
            Vehicle[] vehList = new Vehicle[6];
            int actualValue = 0;
            int expectedValue = 6;
            
            vehList[0] = new Car("A1");
            vehList[1] = new Mc("A2");
            vehList[2] = new Mc("A4");
            vehList[3] = new Trike("A5");
            vehList[4] = new Bike("A6");
            vehList[5] = new Bike("A7");
            int temp;
            // Act
            testLot.TryAddVehicle(vehList[0], out temp);
            testLot.TryAddVehicle(vehList[1], out temp);
            testLot.TryAddVehicle(vehList[2], out temp);
            testLot.TryAddVehicle(vehList[3], out temp);
            testLot.TryAddVehicle(vehList[4], out temp);
            testLot.TryAddVehicle(vehList[5], out temp);
            for(int i = 0; i < 4; i++)
            {
                testSlots[i] = (ParkingSlot)testLot.Content().GetValue(i);
            }
            // Assert
            
            
        }

        [TestMethod]
        public void TryAddVehicle_AddedVehicleInFullLot_IsFalse()
        {
            // Assign

            // Act

            // Assert
        }

        [TestMethod]
        public void TryAddVehicle_ReturnsTrue_IsTrue()
        {
            // Assign

            // Act

            // Assert
        }

        [TestMethod]
        public void TryAddVehicle_ReturnsFalse_IsTrue()
        {
            // Assign

            // Act

            // Assert
        }

        [TestMethod]
        public void TryAddVehicle_OutReturns2_IsTrue()
        {
            // Assign

            // Act

            // Assert
        }

        [TestMethod]
        public void TryAddVehicle_OutReturnsNegative1_IsTrue()
        {
            // Assign

            // Act

            // Assert
        }

    }
}
