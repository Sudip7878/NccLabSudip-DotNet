using System;
namespace NccLabSudip
{
    class greet<T, U>
    {
        public T data1;
        public U data2;
    }
    class program
    {
        static void Main(string[] args)
        {
            greet<string, int> obj = new greet<string, int>();
            obj.data1 = "hello";
            obj.data2 = 123;

            Console.WriteLine($"Data1 = {obj.data1} and Data2 = {obj.data2}");
            Console.ReadLine();
        }
    }
}