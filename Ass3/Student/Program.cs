using System;
using System.Text;

namespace Student
{
    public class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int mark { get; set; }
        private int _scholarship;
        public int scholarship
        {
            get { return _scholarship; }
            set
            {
                if (mark > 8) _scholarship = 500;
                else if (mark >= 7) _scholarship = 300;
                else _scholarship = 0;
            }
        }
        public Student()
        {
            id = "";
            name = "";
            mark = 0;
        }
        public Student(string i)
        {
            id = i;
        }
        public Student(string i, string n, int m)
        {
            id = i;
            name = n;
            mark = m;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("2020608162", "NLT", 9);
            Console.WriteLine(s.scholarship);
            Console.ReadKey();
        }
    }
}
