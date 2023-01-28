using System;


public class Prompts

{
   //List<string> _randomGenerator = new List<string>();
   public string _randomGenerator;
   

   

   

   public Prompts()
   {
    Random random = new Random();
    List<string> test = new List<string>();
    test.Add("What was interesting about your day?");
    test.Add("Was there a bad experience?");
    test.Add("Was their something you can change?");
    test.Add("Was there anything you learned or could have learned?");
    int index = random.Next(test.Count);
    Console.WriteLine(test[index]);


   }

    public void randomPrompt()

    {
        Console.WriteLine(_randomGenerator);
    }
  
    

    

}