using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 objTest = new Class1();
            objTest.Value = 130;
            Program program = new Program();
            program.Test(objTest);
            Console.WriteLine(objTest.Value);
        }
        public void Test(Class1 c)//传递的默认是引用，值会动态地改变！
        {
            int t = 20;
            c.Value = t * 30;
         }
    }
}
