using Microsoft.VisualStudio.TestTools.UnitTesting;
using Railway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Railway.Tests
{
    [TestClass()]
    public class LogComponentTests
    {
        [TestMethod()]
        public void WriteToLogTest_StringShouldBeAddedToLog()
        {
            //Arrange
            LogComponent logComponent = new LogComponent();
            string testString = "Test";

            //Act
            logComponent.WriteToLog(testString);

            //Assert
            Assert.AreEqual(testString, logComponent.GetEntry(0));
        }

        [TestMethod()]
        public void GetLogTest_AddingThreeEntriesShouldMakeLogThreeEntriesLong()
        {
            //Arrange
            LogComponent logComponent = new LogComponent();
            List<string> testStringList = new List<string> { "Test1", "Test2", "Test3" };

            //Act
            foreach (string text in testStringList)
            {
                logComponent.WriteToLog(text);
            }

            //Assert
            Assert.AreEqual(testStringList.Count, logComponent.GetLog().Count);
        }
    }
}