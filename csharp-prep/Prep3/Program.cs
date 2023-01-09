using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randonNumGen = randomGenerator.Next(1, 101);
        int magicNum= -1;

        while (magicNum != randonNumGen)
        {
            Console.Write("What is your guess? ");
            magicNum = int.Parse(Console.ReadLine());

            if (randonNumGen > magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (randonNumGen < magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }  
    }
}