using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PragueParkingDuo.Classes;

namespace PraugeParkingGeneralTest
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void Vehicle_RegSet_IsTrue()
        {
            // Assign
            string expectedValue = "ABC123";
            Vehicle veh = new Vehicle(expectedValue);
            // Act
            string actualValue = veh.Reg;
            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Vehicle_RegSet_IsFalse()
        {
            // Assign
            string notExpectedValue = "CBA321";
            Vehicle veh = new Vehicle("ABC123");
            // Act
            string actualValue = veh.Reg;
            // Assert
            Assert.AreNotEqual(notExpectedValue, actualValue);
        }


        [TestMethod]
        public void Vehicle_Arrival_IsDateTimeNow()
        {
            // Assign
            DateTime expectedValue = DateTime.Now;
            Vehicle veh = new Vehicle("");
            // Act
            DateTime actualValue = veh.Arrival;
            // Assert
            Assert.AreEqual(true, actualValue.Equals(expectedValue));

        }

        [TestMethod]
        public void Vehicle_Arrival_IsNotRandomDate()
        {
            // Assign
            DateTime notExpectedValue = DateTime.Now.AddHours(1);
            Vehicle veh = new Vehicle("");
            // Act
            DateTime actualValue = veh.Arrival;
            // Assert
            Assert.AreEqual(false, actualValue.Equals(notExpectedValue));

        }

        [TestMethod]
        public void Car_Size_Is4()
        {
            // Assign
            int expectedValue = 4;
            Vehicle veh = new Car("");
            // Act
            int actualValue = veh.Size;
            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void Mc_Size_Is2()
        {
            // Assign
            int expectedValue = 2;
            Vehicle veh = new Mc("");
            // Act
            int actualValue = veh.Size;
            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void Trike_Size_Is3()
        {
            // Assign
            int expectedValue = 3;
            Vehicle veh = new Trike("");
            // Act
            int actualValue = veh.Size;
            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void Bike_Size_Is1()
        {
            // Assign
            int expectedValue = 1;
            Vehicle veh = new Bike("");
            // Act
            int actualValue = veh.Size;
            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }


    }
}
