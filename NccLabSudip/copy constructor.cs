using System;
namespace NccLabSudip
{
    internal class player
    {
        public string name;
        public player(string name)
        {
            this.name = name;
            Console.WriteLine("iam original constructor my name is " + this.name);
        }
        public player(player copy)
        {
            name = copy.name;
            Console.WriteLine("iam copy constructor and my name is " + name);
        }
    }
    static void Main(string[] args)
    {
        player player1 = new player("harry");
        player player2 = new player(player1);
        Console.ReadLine();
    }
}