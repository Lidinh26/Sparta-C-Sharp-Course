using NUnit.Framework;
using Labs_42_TestME;
using Labs101_homework;
using Mini_code_Challenge3;
using Mini_code_challenege;
using Mini_code_challenege2;
using Hw_109_linq_aggregate;
using HW_110_Stream_reader_writer;

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

        [TestCase(10, 20, 5, 14.0)]
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

        [TestCase(-1, -1, -1, -1)]

        public void Mini_code_challenge(int initialAge, int initialHeight, int finalAge, int finalHeight)
        {
            //arrange
            var expected = -1;
            //var instance = new Dog();

            //assert
            // var actual = instance.Grow(out int finalheight);

            //act
            //Assert.AreEqual(expected, actual);

        }


        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 21)]
        [TestCase(new int[] { 20, 30, 10 }, 60)]
        [TestCase(new int[] { 1, 2, 3, 1, 2, 1 }, 10)]

        public void Hw_109_linq_Aggregate(int[] array, int expected)
        {
            //pass in array and get back sum : check is valid
            //arrange
            //act
            var actual = LINQAggregate.LINQAggregateSum(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new string[] { "Hello", "You", "OK" }, new string[] { "Hello", "You", "OK", "Buddy" }, new string[] { "Hello", "You", "OK", "Buddy" })]
        [TestCase(new string[] { "Whats", "up", "bro" }, new string[] { "nothing", "much", "you", "know" }, new string[] { "Whats", "up", "bro", "nothing", "much", "you", "know" })]
        [TestCase(new string[] { "It", "is", "Wednesday" }, new string[] { "It", "is", "Tuesday" }, new string[] { "It", "is", "Wednesday", "Tuesday" })]
        public void Hw_109_linq_union(string[] string1, string[] string2, string[] expected)
        {
            //act
            var actual = LINQAggregate.LINQUnion(string1, string2);
            //assert
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new string[] { "Hello", "You", "OK" }, new string[] { "Hello", "You", "OK", "Buddy" }, new string[] { "Hello", "You", "OK" })]
        [TestCase(new string[] { "Li", "Carmen", "Pug" }, new string[] { "Li", "Carmen", "Husky" }, new string[] { "Li", "Carmen" })]
        [TestCase(new string[] { "Sparta", "Global", "2018", "31" }, new string[] { "Sparta", "Global", "2019", "Buddy", "31" }, new string[] { "Sparta", "Global", "31" })]

        public void Hw_109_linq_intersect(string[] string1, string[] string2, string[] expected)
        {
            //act
            var actual = LINQAggregate.LINQIntersect(string1, string2);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]

        public void Hw_109_linq_projectb(int[] int1, int[] int2, int[] expected)
        {
            //act
            var actual = ProjectB.ProjectBUnion(int1, int2);
            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}
