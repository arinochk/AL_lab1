using exercise3;
namespace UnitTest3;

[TestClass]
public class UnitTest1
{

    //создам инициализированные массивы x и y
    int[] x = new int[4] { 1, 1, 2, 2 };
    int[] y = new int[4] { 1, 2, 2, 1 };
    Point[] p = new Point[4];

    [TestMethod]
    public void TestMethod1()
    {
        // Создали массив точек
        for(int i = 0; i < 4; i++)
        {
            p[i] = new Point(x[i], y[i]);

        }
        Figure f = new Figure(ref p);
        f.NameOutput();
        Assert.AreEqual("Четырехугольник", f.Name);
        f.PerimeterCalculator();
        Assert.AreEqual("1", f.Sum); 

    }
}
