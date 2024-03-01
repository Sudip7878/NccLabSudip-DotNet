using System;

namespace NccLabSudip
{
    class greet<T>
    {
        public T data;
    }
    class program
    {
        static void Main(string[] args)
        {
            greet<string> obj = new greet<string>();
            obj.data = "hello";
            Console.WriteLine(obj.data);
            Console.ReadLine();
        }
    }
}