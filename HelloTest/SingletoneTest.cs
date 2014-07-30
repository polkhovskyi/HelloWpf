using HelloPattern.Patterns;
using NUnit.Framework;

namespace HelloTest
{
    public class SingletoneTest
    {
        [Test]
        public void TestSingletone()
        {
            Singleton<string> test = Singleton<string>.Instance;
            test.Value = "first";

            Assert.AreEqual(test.Value, "first");

            var test2 = Singleton<string>.Instance;

            Assert.AreEqual(test2.Value, "first");

            var test3 = Singleton<int[]>.Instance;

            Assert.AreNotEqual(test3.Value, "first");

        }
    }
}
