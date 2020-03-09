using System;
using Xunit;
using Railway;

namespace RailwayTests
{
    public class FileHandlerTests
    {
        [Fact]
        public void ReadFile_ReadFromFile_EqualOutput()
        {
            //Arrange
            string[] result;
            string expectation;
            //Act
            result = FileHandler.ReadFile(@"C:\Users\hampe\My Cloud\Files\Programmering\Dataåtkomster i .NET\the-railway-grupp-1\Source\RailwayTests\TestMockFiles\TestData.txt");
            expectation = "hej,234,2.5";
            //Assert

            Assert.Equal(expectation, result[0]);
        }

        [Fact]
        public void SplitFile_SplitStringArray_SeparatedData()
        {
            //Arrange
            string data;
            string[] result;
            string[] expectation;
            //Act
            data = "hej,234,2.5";
            expectation = new string[] { "hej", "234", "2.5" };
            result = FileHandler.SplitData(data);
            //Assert

            Assert.Equal(expectation, result);

        }
    }

}
