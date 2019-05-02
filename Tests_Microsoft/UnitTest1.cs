using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labs_42_TestME;

namespace Tests_Microsoft
{

    [TestClass]
    public class Demo_Test_For_Lab_42_TestME
    {

        [TestMethod]
        public void Lab_42_TestME_Test01()
        {
            // arrange
            var instance01 = new Testme2();
            var expected = 14;

            // act
            var actual = instance01.BIDMAS01(10, 20, 5);

            // assert
            Assert.AreEqual(expected, actual);

        }


    }


    [TestClass]
    public class Demo_Test_For_Lab_42_TestME2
    {

        [TestMethod]
        public void Lab_42_TestME_Test012()
        {

            // arrange
            var instance02 = new Testme2();
            var expected2 = 53;

            // act
            var actual2 = instance02.BIDMAS01(50, 30, 10);

            // assert
            Assert.AreEqual(expected2, actual2);
        }

    }
}
