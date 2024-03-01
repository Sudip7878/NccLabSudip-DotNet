using System;
namespace NccLabSudip
{
    class greet
    {
        public string sum<T>(T name)
        {
            dynamic x = name;
            return ("hello " + name);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            greet obj = new greet();
            string result = obj.sum("samir");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}