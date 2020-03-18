using Microsoft.VisualStudio.TestTools.UnitTesting;
using Railway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Railway.Tests
{
    [TestClass()]
    public class EngineComponentTests
    {
        [TestMethod()]
        public void StartTest_ShouldChangeIsRunningPropToTrue()
        {
            //Arrange
            EngineComponent engineComponent = new EngineComponent();

            //Act
            engineComponent.Start();

            //Assert
            Assert.IsTrue(engineComponent.IsRunning());
        }

        [TestMethod()]
        public void StopTest_ShouldChangeIsRunningPropToFalse()
        {
            //Arrange
            EngineComponent engineComponent = new EngineComponent();

            //Act
            engineComponent.Start();
            engineComponent.Stop();

            //Assert
            Assert.IsFalse(engineComponent.IsRunning());
        }
    }
}