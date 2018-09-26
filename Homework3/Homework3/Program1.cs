using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public abstract class Graph
    {
        public double area;
        public abstract double GetArea();
    }

    //长方形类  
    public class Rectangle : Graph
    {
        public Rectangle(double length,double width) 
        {
            this.area = length * width;
        }
        public override double GetArea()
        {
            return area;
        }     
    }
    //正方形类  
    public class Square : Graph
    {
        public Square(double length)
        {
            this.area = length * length;
        }
        public override double GetArea()
        {
            return area;
        }
    }
    //三角形类  
    public class Triangle : Graph
    {    
        public Triangle(double sideLen1, double sideLen2,double sideLen3) 
        {
            double p = (sideLen1 + sideLen2 + sideLen3)*0.5;
            this.area = System.Math.Sqrt(p * (p - sideLen1) * (p - sideLen2) * (p - sideLen3));
        }
        public override double GetArea()
        {
            return area;
        }
    }
    //圆形类  
    public class Circle : Graph
    {
        public Circle(double radius)
        {
            double Pi = 3.14;
            area = radius * radius*Pi ;        
        }
        public override double GetArea()
        {
            return area;
        }
    }

    class CreateFactory
    {
        public static Graph getGraph(string type)
        {
            Graph graph = null;
            if (type.Equals("rectangle"))
            {
                double length = 0;
                double width = 0;
                System.Console.WriteLine("\n请输入矩形长和宽：");          
                length = double.Parse(System.Console.ReadLine());
                width = Convert.ToDouble(System.Console.ReadLine());
                graph = new Rectangle(length, width);
            }
            else if (type.Equals("square"))
            {
                double length = 0;
                System.Console.WriteLine("\n请输入正方形边长：");
                length = Convert.ToDouble(System.Console.ReadLine());
                graph = new Square(length);
            }
            else if (type.Equals("circle"))
            {
                double radius = 0;
                System.Console.WriteLine("\n请输入半径：");
                radius = Convert.ToDouble(System.Console.ReadLine());
                graph = new Circle(radius);
            }
            if (type.Equals("triangle"))
            {
                double sideLen1 = 0;
                double sideLen2 = 0;
                double sideLen3 = 0;
                System.Console.WriteLine("\n请输入三角形三边：");
                sideLen1 = Convert.ToDouble(System.Console.ReadLine());
                sideLen2 = Convert.ToDouble(System.Console.ReadLine());
                sideLen3 = Convert.ToDouble(System.Console.ReadLine());
                graph = new Triangle(sideLen1,sideLen2,sideLen3);
            }
            return graph;
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Graph graph1;
            graph1 = CreateFactory.getGraph("rectangle");
            System.Console.WriteLine(graph1.GetArea());

            Graph graph2;
            graph2 = CreateFactory.getGraph("square");
            System.Console.WriteLine(graph2.GetArea());

            Graph graph3;
            graph3 = CreateFactory.getGraph("circle");
            System.Console.WriteLine(graph3.GetArea());

            Graph graph4;
            graph4 = CreateFactory.getGraph("triangle");
            System.Console.WriteLine(graph4.GetArea());
        }
    }
}
