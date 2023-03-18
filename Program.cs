using System;
using System.Text;

namespace Mang
{
    internal class Program
    {
        static void CreateArr(double[] arr)
        {
                Console.WriteLine("\nTạo mảng");
                for(int i = 1; i <= arr.Length; i++)
                {
                    Console.Write("Nhập phần tử thứ " + i + ": ");
                    arr[i - 1] = Convert.ToDouble(Console.ReadLine());
                }
        }
        static double MaxVal(double[] arr)
        {
            double max = arr[0];
            foreach (double i in arr)
                if (i > max)
                    max = i;
            return max;
        }
        static double MinVal(double[] arr)
        {
            double min = arr[0];
            foreach (double i in arr)
                if (i < min)
                    min = i;
            return min;
        }
        static double Sum(double[] arr)
        {
            double sum = 0;
            foreach (double i in arr)
                sum += i;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập mảng. Tìm và hiển thị số lớn nhất," +
                " số nhỏ nhất, tổng các phần tử trong mảng\n");
            int n;
            do
            {
                Console.Write("Nhập số phần tử cho mảng: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Nhập sai. Nhập lại!");
            } while (n <= 0);
            double[] arr = new double[n];
            CreateArr(arr);
            Console.Write("\nMảng đã nhập là: ");
            foreach (double i in arr)
                Console.Write(i + "    ");
            Console.WriteLine("\n\nResult:");
            Console.WriteLine("\nSố lớn nhất trong mảng là: " + MaxVal(arr));
            Console.WriteLine("Số nhỏ nhất trong mảng là: " + MinVal(arr));
            Console.WriteLine("Tổng các phần tử trong mảng là: " + Math.Round(Sum(arr), 5));
            Console.ReadKey();
        }
    }
}
