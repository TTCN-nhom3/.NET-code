using System;
using System.Text;

namespace Person
{
    public class Person
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public void CheckAge()
        {
            if (age >= 18) Console.WriteLine("Bạn đủ tuối bầu cử");
            else Console.WriteLine("Bạn còn nhỏ");
        }
        public void Input()
        {
            Console.Write("Nhập ID: ");
            id = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            name = Console.ReadLine();
            do
            {
                Console.Write("Nhập tuổi: ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0) Console.WriteLine("Nhập sai. Nhập lại!");
            } while (age <= 0);
            Console.Write("Nhập EMail: ");
            email = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            address = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("ID: " + id + "\nHọ tên: " + name + "\nTuổi: " + age);
            Console.WriteLine("EMail: " + email + "\nĐịa chỉ: " + address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin của bạn!");
            Person p = new Person();
            p.Input();
            Console.WriteLine("Thông tin của bạn:");
            p.Output();
            p.CheckAge();
            Console.ReadKey();
        }
    }
}
