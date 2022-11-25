using Lab6task2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6task2
{
    interface IFigure
    {
        double Area { get; }
        string OutputInfo();
    }
    public class Square : IFigure
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }
        public int Side
        {
            get { return side; }
        }
        public int Perimeter
        {
            get { return side * 4; }
        }
        public double Area
        {
            get { return side * side; }
        }
        public string OutputInfo()
        {
            return string.Format($"Figure: Square\n Side size: {Side}\n Perimeter: {Perimeter}\n Area: {Area}\n");
        }
    }
    public class Circle: IFigure
    {
        private double radius;
        private string color;
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double Radius
        {
            get { return radius; }
        }
        public string Color
        {
            get { return color; }
        }
        public double Area
        {
            get { return Math.PI * Math.Pow(radius, 2); }
        }
        public string OutputInfo()
        {
            return string.Format($"Figure: Circle\n Radius size: {Radius}\n Figure color: {Color}\n Area: {Area}\n");
        }
    }
    class FigureArray: IEnumerable
    {
        IFigure[] figure;

        public FigureArray(params IFigure[] fig)
        {
            figure = fig;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return figure.GetEnumerator();
        }
    }
}
    public class Program
    {
        public static void Main()
        {
        FigureArray figure = new FigureArray
            (
            new Square(5),
            new Square(33),
            new Circle(23.456, "purple"),
            new Circle(1.1, "white")
            );

        foreach (IFigure value in figure)
        {
            Console.WriteLine(value.OutputInfo());
        }
    }
    
}
