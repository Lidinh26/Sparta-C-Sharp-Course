using NUnit.Framework;
using Rabbit_explosion_game;

namespace Tests
{
    public class Tests
    {
        /// <summary>
        /// Tests the rabbit counter method
        /// </summary>
        /// <param name="seconds">the counter is running for>The amount of time</param>
        /// <param name="rabbits">the number of rabbitd in the counter</param>

        [TestCase(0, 2)]
        [TestCase(1, 4)]
        [TestCase(2, 8)]
        [TestCase(3, 16)]
        [TestCase(4, 32)]
        [TestCase(5, 64)]
        [TestCase(16, 100000)] // if population is set to 100k

        public void TestRabbitCounter(int seconds, int rabbitsExpected)
        {
            // arrange

            // act
            var result = Program.RabbitCounter(seconds)[seconds]; //ArrayList

            // assert
            Assert.AreEqual(rabbitsExpected, result);
        }
    }
}