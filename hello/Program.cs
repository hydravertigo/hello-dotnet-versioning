﻿namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        var number = int.Parse(Console.ReadLine());

        if ( number % 2 == 0) {
            Console.WriteLine("The number " + number + " is even.");
        } else {
            Console.WriteLine("The number " + number + " is odd.");
        }

    }
}
