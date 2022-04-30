// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int returnValue = random.Next(1, 6);
        int guess = 0;
        Console.WriteLine("Think of a number between 1-6. Can you guess what it is?");
        if (guess != returnValue)
        {
            guess = Convert.ToInt32(Console.Read());
            Console.WriteLine("Try again! The answer was " + returnValue);
            Console.ReadLine();
        }
        if (guess == returnValue)
        {
            Console.WriteLine("Well done! The answer was " + returnValue);
            Console.ReadLine();
        }
    }
}