using System;

class rectangle
{
    public int length;
    public int breadth;

    public rectangle(int length, int breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }

    public object this[int i]
    {
        get
        {
            if (i == 0)
                return this.length;
            else if (i == 1)
                return this.breadth;
            else
                return null;
        }
        set
        {
            if (i == 0)
                this.length = (int)value;
            else if (i == 1)
                this.breadth = (int)value;

        }
    }
}

class program
{
    static void Main(string[] args)
    {
       rectangle rectangle1 = new rectangle(3,5);
        rectangle1[0] = 9;
        rectangle1[1] = 8;
        Console.WriteLine("length is " + rectangle1[0] + " breadth is " + rectangle1[1]);
        Console.ReadLine(); 
    }
}