// Задание 1 и 2
namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine($"Обьект: Sbyte;  принимает от {sbyte.MinValue}  до {sbyte.MaxValue}  ");
            Console.WriteLine($"Обьект: Byte;  принимает от {byte.MinValue}  до {byte.MaxValue}  ");
            Console.WriteLine($"Обьект: Int16;  принимает от {int.MinValue}  до {int.MaxValue}  ");
            Console.WriteLine($"Обьект: UInt16;  принимает от {uint.MinValue}  до {uint.MaxValue}  ");
            Console.WriteLine($"Обьект: UInt64;  принимает от {long.MinValue}  до {long.MaxValue}  ");
            Console.WriteLine($"Обьект: Decimal;  принимает от {decimal.MinValue}  до {decimal.MaxValue}  ");
            Console.WriteLine($"Обьект: Float;  принимает от {float.MinValue}  до {float.MaxValue}  ");
            Console.WriteLine($"Обьект: Double;  принимает от {double.MinValue}  до {double.MaxValue}  ");
        }

    }
    public class Rectangle
    {
        private double side1, side2;
        double AreaCalculator()
        {
            return side1 * side2;
        }
        double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        public Rectangle(double sideA, double sideB)
        {
            this.side1 = sideA;
            this.side2 = sideB;
        }
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}

