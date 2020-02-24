using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 15;

            string s1 = "This is string";
            string s2 = "This is string";

            Student st1 = new Student("John", 25);
            Student st2 = new Student("John", 25);
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
        }
    }

    internal class Student
    {
        private string v1;
        private int v2;

        public Student(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
