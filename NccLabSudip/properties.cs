using System;
namespace NccLabSudip
{
    internal class player
    {
        int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("age cannot be negative");
                    return;
                }
                else
                {
                    age = value;
                }
            }
        }
        public player(int age)
        {
            Age = age;
            Console.WriteLine("age is " + Age);
        }

        static void Main(string[] args)
        {
            player player1 = new player(2);
            Console.ReadLine();
        }
    }
}