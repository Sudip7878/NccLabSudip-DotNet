using System;
namespace NccLabSudip
{
    public delegate void mydelegate(string msg);
    class greet
    {
        public void sayhello(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            greet gt = new greet();
            mydelegate delegate1 = new mydelegate(gt.sayhello);
            //mydelegate delegate1 = gt.sayhello;
            delegate1("hello iam inside delegate");
            Console.ReadLine();
        }
    }
}