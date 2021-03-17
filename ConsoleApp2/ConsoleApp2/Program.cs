using System;

namespace ConsoleApp2
{
    class Car{ 
        public int speed;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car();
            Car b = new Car();
            a.speed = 10;
            Console.WriteLine(a.speed);
            b = a;
            b.speed = 20;
            Console.WriteLine(a.speed);//引用可以修改

            Console.WriteLine("Hello World!");
        }
    }
}
