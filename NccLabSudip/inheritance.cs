using System;

class shape
{
    int length = 12; int breadth = 23;
    public int area1()
    {
        return length * breadth;
    }

}
class rectangle : shape
{

}

class program
{
    static void Main(string[] args)
    {
        shape shape1 = new rectangle();
        Console.WriteLine("area of rectangle is " + shape1.area1());
        Console.ReadKey();
    }
}