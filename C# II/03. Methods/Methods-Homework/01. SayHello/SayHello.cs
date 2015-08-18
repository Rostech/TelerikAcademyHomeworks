using System;

class SayHello
{
    /*
      1. Say Hello

    Write a method that asks the user for his name and prints “Hello, <name>”
    Write a program to test this method.

    */

    static void SayHelloMethod(string name)
    {
        Console.WriteLine("Hello, {0}! ", name);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        SayHelloMethod(Console.ReadLine());
    }
}

