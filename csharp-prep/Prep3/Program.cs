using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random ();
        int number = randomGenerator.Next (1,11); 

        Console.Write($"What is the magic number? {number} "); 
        string mnumber = Console.ReadLine();
        
        Console.Write("What is your guess? ");
        string gnumber = Console.ReadLine(); 

        while (mnumber == gnumber)
        {
            Console.Write("You guessed it");
        }


    }
}