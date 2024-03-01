using System;

class animal
{
    public string color = "black";
}
class cow : animal
{
    public cow()
    {
        Console.WriteLine("color is " + base.color);
    }
}
class program
{
    static void Main(string[] args)
    {
        cow monu = new cow();
        Console.ReadKey();
    }
}