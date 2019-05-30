using NUnit.Framework;
using Labs_42_TestME;
using Labs101_homework;
using Mini_code_Challenge3;
using Mini_code_challenege;
using Mini_code_challenege2;
using Lab_HW_106_Interview_Prep;


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

        [TestCase(-1,-1,-1,-1)]

        public void Mini_code_challenge(int initialAge, int initialHeight, int finalAge, int finalHeight )
        {
            //arrange
            var expected = -1;
            var instance = new Dog();

            //assert
            var actual = instance.Grow(out int finalheight);

            //act
            Assert.AreEqual(expected, actual);
            

        }

        [TestCase("hello",3,108)]
        [TestCase("world",5,-1)]     
        [TestCase("world",2,114)]
        
        public void ASCII_Return_Index_Of_String(string input, int index, int expected)
        {
            //arange
            var instance = new ASCII();
            var actual = instance.ASCII_Return_Index_Of_String(input, index);
                
            //assert
            Assert.AreEqual(expected, actual);

            //Act
        }

    }
}