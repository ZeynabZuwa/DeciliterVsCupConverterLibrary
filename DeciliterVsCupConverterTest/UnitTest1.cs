using DeciliterVsCupConverterLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeciliterVsCupConverterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_convert_deciliter_to_cup()
        {
            //Arrange

            Cup cup = 2.0;

            //Act
            Deciliter expected = 0.83;

            Deciliter actual = (cup);

            //Assert

            Assert.AreEqual(expected.Dl, actual.Dl, 0.01);

        }

        [TestMethod]
        public void Test_convert_cup_to_deciliter()
        {
            //Arrange

            Deciliter deciliter = 5.0;

            //Act
            Cup expected = 2.0;

            Cup actual = (deciliter);

            //Assert

            Assert.AreEqual(expected.cup, actual.cup, 0.01);

        }
    }
}