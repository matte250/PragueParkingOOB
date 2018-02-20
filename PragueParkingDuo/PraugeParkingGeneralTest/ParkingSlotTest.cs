using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PragueParkingDuo.Classes.Parking;
using PragueParkingDuo.Classes;

namespace PraugeParkingGeneralTest
{
    [TestClass]
    public class ParkingSlotTest
    {
        [TestMethod]
        public void AddVehicle_IfVehicleDoesFit_IsTrue()
        {
            // Assign
            ParkingSlot slot = new ParkingSlot();
            Car car = new Car("ABC123");
            // Act
            slot.AddVehicle(car);
            // Assert
            Assert.AreEqual(true, slot.Content().Contains(car));
        }

        [TestMethod]
        public void AddVehicle_IfVehicleDoesNotFit_IsTrue()
        {
            // Assign
            ParkingSlot slot = new ParkingSlot();
            Car car = new Car("ABC123");
            Bike bike = new Bike("BCA123");
            // Act
            try
            {
                slot.AddVehicle(car);
                slot.AddVehicle(bike);
            }
            // Assert
            catch (Exception e)
            {
                Assert.Equals(e.GetType(),typeof(OverflowException));             
            }
            Assert.Fail();
        }

        [TestMethod]
        public void AddVehicle_IfVehicleFitsWithOthers_IsTrue()
        {
            // Assign
            ParkingSlot slot = new ParkingSlot();
            Trike trike = new Trike("ABC123");
            Bike bike = new Bike("BCA123");
            bool actualBool = false;

            // Act       
            slot.AddVehicle(trike);
            slot.AddVehicle(bike);

            // Assert
            if (slot.Content().Contains(trike) && slot.Content().Contains(bike)) actualBool = true;
            Assert.AreEqual(true, actualBool);
            
        }
        [TestMethod]
        public void RemoveVehicle_IfRemovedVehicleIsRemoved_IsTrue()
        {
            // Assign
            ParkingSlot slot = new ParkingSlot();
            Bike bike1 = new Bike("B1");
            Bike bike2 = new Bike("B2");
            Bike bike3 = new Bike("B3");
            Bike bike4 = new Bike("B4");
            bool actualBool = false;

            // Act
            slot.AddVehicle(bike1);
            slot.AddVehicle(bike2);
            slot.AddVehicle(bike3);
            slot.AddVehicle(bike4);

            slot.RemoveVehicle("B1");

            // Assert
            if (!slot.Content().Contains(bike1) && slot.Content().Contains(bike2)) actualBool = true;
            Assert.AreEqual(true, actualBool);
        }

        [TestMethod]
        public void RemoveVehicle_IfRemovedVehicleDoesNotExist_IsTrue()
        {
            // Assign
            ParkingSlot slot = new ParkingSlot();
            Bike bike1 = new Bike("B1");
            Bike bike2 = new Bike("B2");
            Bike bike3 = new Bike("B3");
            Bike bike4 = new Bike("B4");

            // Act
            slot.AddVehicle(bike1);
            slot.AddVehicle(bike2);
            slot.AddVehicle(bike3);
            slot.AddVehicle(bike4);

            slot.RemoveVehicle("Reg that does not exist.");

            // Assert

            Assert.AreEqual(4, slot.Content().Count);
        }

    }
}
