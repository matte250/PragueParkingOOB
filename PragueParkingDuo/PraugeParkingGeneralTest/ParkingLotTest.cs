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
            // Act
            testLot.TryAddVehicle<Car>("ABC123",out int temp);
            testSlot = testLot.Content()[0];
            // Assert

        }

        [TestMethod]
        public void TryAddVehicle_AddedVehicleToPartialyFullLot_IsTrue()
        {
            // Assign

            // Act

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
