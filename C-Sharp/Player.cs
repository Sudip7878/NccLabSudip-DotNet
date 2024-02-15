using System;
namespace NccLabSudip
{
    internal class player
    {
        public int sum(int a, int b) { return a + b; }
        public int sum(int a, int b, int c) { return a + b + c; }
        public int sum(int a, int b, int c, int d) { return a + b + c + d; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            player harry = new player();
            Console.WriteLine("sum is:" + harry.sum(1, 2));
            Console.ReadLine();
        }
    }

}
