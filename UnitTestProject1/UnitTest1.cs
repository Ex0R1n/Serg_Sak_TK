using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace ConsoleApp1UnitTest
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestResultCalc()
        {
            int score_1 = 5;
            int score_2 = 10;
            int score_3 = 15;

            int expectedResult = score_1 + score_2 + score_3;

            int actualResult = Program.ResultCalc(score_1, score_2, score_3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestScore1InRange()
        {
            int score_1 = 20;

            bool result = score_1 >= 0 && score_1 <= 22;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestScore2InRange()
        {
            int score_2 = 30; 

            bool result = score_2 >= 0 && score_2 <= 38;

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestScore3InRange()
        {
            int score_3 = 18; 

            bool result = score_3 >= 0 && score_3 <= 20;

            Assert.IsTrue(result);
        }
    }
}
