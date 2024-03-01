using System;

class class1
{
    public void show()
    {
        Console.WriteLine("iam base class ");
    }
}

class class2 : class1
{
    public new void show()
    {
        Console.WriteLine("iam derived class");
    }
}
class program
{
    static void Main(string[] args)
    {
        class2 c = new class2();
        c.show();
        Console.ReadKey();
    }
}