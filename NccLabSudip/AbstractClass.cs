using System;
abstract class player
{
    public virtual void display()
    {
        Console.WriteLine("iam player");
    }
}

class coach : player
{
    public override void display()
    {
        Console.WriteLine("iam player and coach as well");
    }
}
class program
{
    static void Main(string[] args)
    {
        coach ram = new coach();
        ram.display();
        Console.ReadLine();
    }
}
