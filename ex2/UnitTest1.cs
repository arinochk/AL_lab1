using exercise2;



[TestClass]
public class UnitTest1
{
    
    Rectangle a = new Rectangle(4, 3);
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(12, a.Area);
        Assert.AreEqual(14, a.Perimeter);
    }
    Rectangle b = new Rectangle(1.5, 1.5);
    public void TestMethod2()
    {
        Assert.AreEqual(2.25, a.Area);
        Assert.AreEqual(6, a.Perimeter);
    }
}
