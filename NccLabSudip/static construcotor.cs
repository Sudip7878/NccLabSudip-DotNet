using System;

namespace NccLabSudip
{
    internal class player
    {
        static public int age = 23;
        static player()
        {
            Console.WriteLine("static constructor");
        }
    }
    class proram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(player.age);
            Console.ReadLine();
        }
    }
}
