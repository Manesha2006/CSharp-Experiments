using System;

class Student
{
    // Data members
    public string name;
    public int age;

    // Method
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        // Creating an object
        Student s1 = new Student();

        // Assigning values
        s1.name = "Manisha";
        s1.age = 20;

        // Calling the method
        s1.Display();

        Console.ReadLine();
    }
}