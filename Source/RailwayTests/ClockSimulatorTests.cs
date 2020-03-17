using Microsoft.VisualStudio.TestTools.UnitTesting;
using Railway;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Railway.Tests
{
    [TestClass()]
    public class ClockSimulatorTests
    {

        [TestMethod()]
        public void SetTimeTest_SetClockSimTime_ClockSimTimeIs1100()
        {
            //Arrange
            ClockSimulator clockSim = new ClockSimulator(1, 60);

            //Act
            clockSim.SetTime(new TimeSpan(11, 00, 00));

            //Assert
            Assert.AreEqual("11:00", clockSim.TimeToString());
        }


        [TestMethod()]
        public void GetDateTimeTest_ShouldReturnSetDateTime()
        {
            //Arrange
            DateTime now = DateTime.Now;
            ClockSimulator clockSim = new ClockSimulator(1, 60, now);

            //Act

            //Assert
            Assert.AreEqual(now, clockSim.GetDateTime());
        }


        [TestMethod()]
        public void StartClockTest_RunningClockShouldResultInADifferentTimeFromNow()
        {
            //Arrange
            DateTime now = DateTime.Now;
            ClockSimulator clockSim = new ClockSimulator(1, 60, now);

            //Act
            clockSim.StartClock();
            Thread.Sleep(5);
            clockSim.StopClock();

            //Assert
            Assert.AreNotEqual(now, clockSim.GetDateTime());
        }
    }
}