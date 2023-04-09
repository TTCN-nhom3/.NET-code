using System;
using System.Text;

namespace Circle
{
    public class Circle
    {
        public double radius { get; set; }
        public Circle() { radius = 0; }
        public Circle(double r) { radius = r; }
        public double Area() { return Math.Round(Math.PI * radius * radius, 3); }
        public double Perimeter() { return Math.Round(Math.PI * radius * 2, 3); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double r;
            do
            {
                Console.Write("Nhập bán kính hình tròn: ");
                r = double.Parse(Console.ReadLine());
                if (r <= 0) Console.WriteLine("Nhập sai. Nhập lại");
            } while (r <= 0);
            Circle c = new Circle(r);
            Console.WriteLine("Diện tích hình tròn là: " + c.Area());
            Console.WriteLine("Chu vi hình tròn là: " + c.Perimeter());
            Console.ReadKey();
         }
    }
}