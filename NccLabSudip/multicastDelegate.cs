using System;
namespace NccLabSudip
{
    public delegate void mydelegate(int a, int b);
    class greet
    {
        public void addnum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void subnum(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            greet gt = new greet();
            mydelegate d1 = gt.addnum;
            mydelegate d2 = gt.subnum;
            mydelegate d3 = d1 + d2;
            d3(6, 4);
            d3 -= d2;
            Console.ReadLine();
        }
    }
}