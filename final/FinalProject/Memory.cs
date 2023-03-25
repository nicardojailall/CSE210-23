using System;

public class Memory : IntelligentTest

{   
    private string _memorise;
    public Memory(string welcome, string memorise) : base(welcome)
    {
        _memorise = memorise;
    }
    public string GetMemorise()
    {
        return _memorise;
    }
    public override void points()
    {
        string readPoints = File.ReadAllText("IQ.txt");
        int values = Int32.Parse(readPoints);
        Console.Write($"\nYour Memory Percentage: {readPoints}%\n");
    } 

    public void GetMemory()
    
    {   
        string[] memoryAnswer = {"5","semester","This", "This was a good semester"};
        string memoryAnswer1;
        string memoryAnswer2;
        string memoryAnswer3;
        string memoryAnswer4;
        int points = 0;
        Console.Write("\nThis was a good semester\n");
        GetAnimations();
        Console.Clear();
        Console.Write("How many words in the sentence? ");
        memoryAnswer1 = Console.ReadLine();
        if (memoryAnswer1 == memoryAnswer[0])
        {
            points += 1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }

        Console.Write("\nType the last word of the sentence: ");
        memoryAnswer2 = Console.ReadLine();
        if ( memoryAnswer2 == memoryAnswer[1])
        {
            points += 1;
            Console.Write("Correct");   
            
        }
         else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nType the first word of the sentence: ");
        memoryAnswer3 = Console.ReadLine();
        if (memoryAnswer3 == memoryAnswer[2])
        {
            points += 1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nType out the sentence: ");
        memoryAnswer4 = Console.ReadLine();
        if (memoryAnswer4 == memoryAnswer[3])
        {
            points += 1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        int percentage = 0;
        if (points == 1)
        {
            int calculateOne = 1 * 100 / 4;
            percentage = calculateOne;
            
        }
        if (points == 2)
        {
            int calculateOne = 2 * 100 / 4;
            percentage = calculateOne;
            
        }
        if (points == 3)
        {
            int calculateOne = 3 * 100 / 4;
            percentage = calculateOne;
            
        }
        if (points == 4)
        {
            int calculateOne = 4 * 100 / 4;
            percentage = calculateOne;
            
        }
        if (points == 0)
        {
            int calculateOne = 0 * 100 / 4;
            percentage = calculateOne;
            
        }
        using (StreamWriter outputFile = new StreamWriter("IQ.txt"))
        {
            outputFile.Write(percentage);
        }
          // string readPoints = File.ReadAllText("percentage.txt");
           // int values = Int32.Parse(readPoints);
           // int calculate1 = values * 100;
           // int calculate2 = percentage * 100;
           // int calculate3 = calculate1 + calculate2;
           // int totalPercentage = calculate3 / 200;
            
           // using (StreamWriter outputFile = new StreamWriter("percentage.txt"))
           // {
              // outputFile.Write(totalPercentage);
            //}
            
            
        
        
    } 
       
     
    

}