using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squareTest = new Square();
            Rectangle rectangleTest = new Rectangle();
            Circle circleTest = new Circle();

            Console.WriteLine(squareTest.area());
            Console.WriteLine(circleTest.circumference);
            Console.WriteLine(rectangleTest.height);
        }
    }
}
