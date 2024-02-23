using System;

namespace InterfaceApp
{

    interface animal
    {
        void makesound();
        void eat();
    }


    interface car
    {
        void modelname();
        void price();
    }
    class cow : animal, car
    {
        public void makesound()
        {
            Console.WriteLine("moo moo");
        }
        public void eat()
        {
            Console.WriteLine("eat grass");
        }

        public void modelname()
        {
            Console.WriteLine("bmw");
        }
        public void price() { Console.WriteLine("2000"); }
    }
    class program
    {
        static void Main(string[] args)
        {
            cow cow = new cow();
            cow.makesound();
            cow.price();
            Console.ReadLine();
        }
    }
}
