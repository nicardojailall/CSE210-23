using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {  
        
        Referrence referrence = new Referrence("Exodus ", "20:8-9 : ");
        Console.Write(referrence.GetBookString());
        Console.Write(referrence.GetVerseString());
        Referrence referrence1 = new Referrence(" Remember the sabbath day, to keep it holy.  Six days shalt thou labour, and do all thy work.");
        File.WriteAllText("verses.txt",referrence1.GetText0());
        
        Words words = new Words();
        Console.Write(words.GetTextString());
        string[] wordi = words.GetTextString().Split(' ');
        Words words1 = new Words("\nPress enter to continue or type 'quit' to end.");
        Console.Write(words1.GetPromptString());
        string end = Console.ReadLine();
        Console.Clear();
        Scripture scripture = new Scripture($"{referrence.GetBookString()}{referrence.GetVerseString()}Remember the sabbath day, to keep it holy.  Six days shalt thou labour, and do all thy work.");
        
        StringBuilder text = new StringBuilder(scripture.GetScriptureText());
        
        for (int i = 0; i < text.ToString().Length; i++)
        {
            text.Replace("work.", "_____");
            text.Replace("the", "");
            text.Replace("days", "____");
            text.Replace("thou", "____");
            text.Replace("day,", "____");
            
            
        }
        Console.Write(text);   
        Words words2 = new Words("\nPress enter to continue or type 'quit' to end.");
        Console.Write(words2.GetPromptString());
        string end2 = Console.ReadLine();
        Console.Clear();
        for (int i = 0; i < text.ToString().Length; i++)
        {
            text.Replace("keep", "____");
            text.Replace("sabbath", "______");
            text.Replace("holy.", "_____");
            text.Replace(", and do", "________");

        }
        Console.Write(text);
        Words words3 = new Words("\nPress enter to continue or type 'quit' to end.");
        Console.Write(words3.GetPromptString());
        string end3 = Console.ReadLine();
        Console.Clear();
         
        for (int i = 0; i < text.ToString().Length; i++)
        {
            text.Replace("Remember", "______");
            text.Replace("to", "__");
            text.Replace("it", "__");
            text.Replace("Six", "___");
            text.Replace("shalt", "____");
            text.Replace("labour", "______");
            text.Replace("all thy", "__ ___");

        }
        Console.Write(text);
        string end4 = Console.ReadLine();
        Console.Clear();
    }

       
}