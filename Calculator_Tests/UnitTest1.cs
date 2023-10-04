using Sqrt_Calculator;

namespace Calculator_Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void XHigherThan0()
    {
        Calculator cal = new Calculator();
        double res = cal.Sqrt(4);
        Assert.AreEqual(res,2);
    }

    [TestMethod]
    public void XLowerThan0()
    {
        Calculator cal = new Calculator();
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => cal.Sqrt(-4));
    }
}