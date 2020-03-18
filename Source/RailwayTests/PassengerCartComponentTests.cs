using Microsoft.VisualStudio.TestTools.UnitTesting;
using Railway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Railway.Tests
{
    [TestClass()]
    public class PassengerCartComponentTests
    {
        [TestMethod()]
        public void AddPassengersTest_AddDesignatedAmountToProp()
        {
            //Arrange
            PassengerCartComponent passengerCartComponent = new PassengerCartComponent();
            int amount = 10;

            //Act
            passengerCartComponent.AddPassengers(amount);

            //Assert
            Assert.AreEqual(amount, passengerCartComponent.GetPassengerAmount());
        }

        [TestMethod()]
        public void RemovePassengersTest_TryingToSubtractBelowZeroShouldResultInZero()
        {
            //Arrange
            PassengerCartComponent passengerCartComponent = new PassengerCartComponent(0);
            int amount = 10;

            //Act
            passengerCartComponent.RemovePassengers(amount);

            //Assert
            Assert.AreEqual(0, passengerCartComponent.GetPassengerAmount());
        }

        [TestMethod()]
        public void RemovePassengersTest_SubtractDesignatedAmountFromProp()
        {
            //Arrange
            PassengerCartComponent passengerCartComponent = new PassengerCartComponent(20);
            int amount = 10;

            //Act
            passengerCartComponent.RemovePassengers(amount);

            //Assert
            Assert.AreEqual(10, passengerCartComponent.GetPassengerAmount());
        }
    }
}