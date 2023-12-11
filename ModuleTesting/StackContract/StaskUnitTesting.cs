using NUnit.Framework;

namespace StackByContract
{
    public class StaskUnitTesting
    {
        [Test]
        public void Test()
        {
            StringStack stack = new StringStack();

            stack.Push(null);

            Assert.AreEqual(null, stack.Pop());
        }
    }
}
