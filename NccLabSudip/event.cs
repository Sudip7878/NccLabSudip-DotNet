using System;
namespace NccLabSudip
{

    //event 
    class greet
    {
        public delegate void dg_OddNumber();  //delegate
        public event dg_OddNumber ev_OddNumber; //event
        public void add()
        {
            int result;
            result = 5 + 3;
            Console.WriteLine(result.ToString());
            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber();
            }
        }

    }

    class program
    {
        static void Main(string[] args)
        {
            greet obj = new greet();
            obj.ev_OddNumber += new greet.dg_OddNumber(EventMessage);
            obj.add();
            Console.ReadLine();
        }
        static void EventMessage()
        {
            Console.WriteLine("event executed");
        }
    }
}