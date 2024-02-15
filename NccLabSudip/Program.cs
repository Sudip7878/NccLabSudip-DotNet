using System;

abstract class vechile
{
    public string brand;
    public int price;
    public abstract void display(string brand,int price);
}

class Car: vechile
{
    public override void display(string brand,int price)
    {
        Console.WriteLine("price of is "+price);
        Console.WriteLine("name of brand is " + brand);
    }
}
class program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.display("maruti", 344444);
        Console.ReadKey();
    }
}