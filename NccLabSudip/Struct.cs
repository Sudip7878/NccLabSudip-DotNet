using System;

struct animal
{
    public string color;
    public int age;

    public animal(string color1, int age1)
    {
        color = color1;
        age = age1;
    }

    public void display()
    {
        Console.WriteLine("color of animal is " + color + " and age is " + age);
    }

}
class program
{
    static void Main(string[] args)
    {
        animal cow = new animal("white", 9);
        cow.display();
        Console.ReadKey();
    }
}