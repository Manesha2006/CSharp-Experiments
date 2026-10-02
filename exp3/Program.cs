using System;

class Number
{
    public int value;

    public Number(int value)
    {
        this.value = value;
    }

    // Overloading + operator
    public static Number operator +(Number n1, Number n2)
    {
        return new Number(n1.value + n2.value);
    }

    public void Display()
    {
        Console.WriteLine("Result = " + value);
    }
}

class Program
{
    static void Main()
    {
        Number n1 = new Number(10);
        Number n2 = new Number(20);

        Number n3 = n1 + n2;

        n3.Display();

        Console.ReadLine();
    }
}