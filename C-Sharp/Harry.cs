using System;

namespace NccLabSudip
{
    internal class hero
    {
        public string name = "harry";
        public int health = 34;
    }
    class program1
    {
        static void Main(string[] args)
        {
            hero sw = new hero();
            Console.WriteLine(sw.name);
            Console.WriteLine(sw.health);
            Console.ReadLine();
        }
    }
}