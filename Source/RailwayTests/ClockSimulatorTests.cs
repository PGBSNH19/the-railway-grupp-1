using Microsoft.VisualStudio.TestTools.UnitTesting;
using Railway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Railway.Tests
{
    [TestClass()]
    public class ClockSimulatorTests
    {

        [TestMethod()]
        public void SetClockSimTime_SetTimeTest_ClockSimTimeIs1100()
        {
            //Arrange
            ClockSimulator clockSim0 = new ClockSimulator(1, 60);

            //Act
            clockSim0.SetTime(new TimeSpan(11, 00, 00));

            //Assert
            Assert.AreEqual("11:00:00", clockSim0.TimeToString());
        }
    }
}