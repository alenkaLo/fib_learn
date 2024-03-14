namespace Fib.Tests;
using FibPro;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {   
        ulong f1 = Fib.FibIter(1);
        ulong a = 0;
        Assert.AreEqual(f1, a);
    }
}