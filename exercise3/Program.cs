using System;

class Program
{
    static void Main(string[] args)
    {

    }
}
namespace exercise3
{

    public class Point
    {
        int x, y;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Figure
    {
        int v; // Количество вершин
        Point[] p;
        public string Name { get; set; } //автосвойство для хранения названия фигуры
                                         // Метод для вывода названия фигуры
        public double Sum { get; set; }                                 //Конструктор
        public Figure(ref Point[] p)
        {
            v = p.Length;         //Определим размер массива 
            this.p = new Point[v];                           //Инициализаруем массив класса 
                                                             //Создадим цикл Приравняем массив класса к переданному
            for (int i = 0; i < v; i++)
            {
                this.p[i] = p[i];
            }
        }
        // Метод для вывода названия фигуры
        public void NameOutput()
        {
            if (v == 3)
            {
                Name = "Треугольник";
                Console.WriteLine(Name);
            }
            else if (v == 4)
            {
                Name = "Четырехугольник";
                Console.WriteLine(Name);
            }
            else if (v == 5)
            {
                Name = "Пятиугольник";
                Console.WriteLine(Name);
            }
            else
            {
                Name = "Многоугольник";
                Console.WriteLine(Name);
            }
        }
        public void PerimeterCalculator()
        {
            double Sum = 0;
            Point h = this.p[0];
            for (int i = 1; i < v; i++)
            {
                Sum = +this.LengthSide(h, p[i]);
                h = p[i];
            }
            Console.WriteLine(Sum);
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((A.X - B.X) ^ 2 + (A.Y - B.Y) ^ 2);
        }
    }
}