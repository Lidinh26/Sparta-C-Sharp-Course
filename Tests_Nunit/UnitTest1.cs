using NUnit.Framework;
using Labs_42_TestME;
using Labs101_homework;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }



        [Test]
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

        [TestCase(10,20,5,14.0)]
        [TestCase(20, 30, 6, 25.0)]
        [TestCase(30, 50, 10, 35)]

        public void Lab_42_TestME_Test02(int a, int b, int c, double expected)
        {
            // arrange
            var instance01 = new Testme2();

            // act
            var actual = instance01.BIDMAS01(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);

        }


        [TestCase(1, 2, 3, 4, 5, -1)]
        public void Labs101_homework(int a, int b, int c, int d, int e, int expected)
        {
                var actual = Collections.UseCollections(a, b, c, d, e);

          
          Assert.AreEqual(expected, actual);
         
        }

        //arrange
        //act



    }
}