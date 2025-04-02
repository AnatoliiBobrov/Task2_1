using LearnDLL;
using NUnit.Framework;

namespace Task2_1
{
    public class LearnDLLTest
    {
        [TestCase(int.MaxValue, 255)]
        [TestCase(40, 255)]
        [TestCase(-1, 1)]
        [TestCase(-256, 0)]
        public static void TestDifference(int arg, int right)
        {
            var v1 = new MainClass(0);
            NUnit.Framework.Assert.That(v1.GetDifference(arg) == right);
        }

        [TestCase(256)]
        [TestCase(3)]
        [TestCase(-13)]
        public static void TestConstructor(int arg)
        {
            var v1 = new MainClass(arg);
        }
    }
}