using System;
namespace NccLabSudip
{
    public partial class greet
    {
        public void method1()
        {
            Console.WriteLine("iam method1");
        }
    }

    public partial class greet
    {
        public void method2()
        {
            Console.WriteLine("iam method2");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            greet obj = new greet();
            obj.method1();
            obj.method2();
            Console.ReadLine();
        }
    }
}