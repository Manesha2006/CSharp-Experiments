using System;

class Program
{
    // Declare a delegate
    public delegate void MyDelegate();

    // Event
    public static event MyDelegate MyEvent;

    // Event handler method
    public static void ShowMessage()
    {
        Console.WriteLine("Event is triggered successfully.");
    }

    static void Main()
    {
        // Attach method to delegate
        MyDelegate del = ShowMessage;

        // Attach delegate to event
        MyEvent += del;

        // Raise the event
        MyEvent?.Invoke();

        Console.ReadLine();
    }
}