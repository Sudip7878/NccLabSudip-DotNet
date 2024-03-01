using System;
namespace NccLabSudip
{
    internal class player
    {
        public player(string name)
        {
            Console.WriteLine("hello " + name);
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            player harry = new player("harry");
            Console.ReadLine();
        }
    }

}
