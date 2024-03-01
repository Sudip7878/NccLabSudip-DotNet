using System;

interface animal
{
    void makesound();
    void eat();
}
class cow : animal
{
    public void makesound()
    {
        Console.WriteLine("moo moo");
    }
    public void eat()
    {
        Console.WriteLine("eat grass");
    }
}
class program
{
    static void Main(string[] args)
    {
        cow cow = new cow();
        cow.makesound();
        Console.ReadLine();
    }
}