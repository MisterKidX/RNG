using RNG.RandomEngines;

namespace RNGTestSuite
{
    [TestClass]
    public class TestRandomEngine_SystemRandom
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            var rand = new SystemRandom();
        }

        [TestMethod]
        public void TestSeedConstructor()
        {
            var rand = new SystemRandom(0);
            rand = new SystemRandom(1);
            rand = new SystemRandom(int.MinValue);
            rand = new SystemRandom(int.MaxValue);
        }
    }
}