using System;
public class IntelligentTest
{
    
    private string _animations;
    private string _welcome;

    public IntelligentTest(string welcome)
    {
        _welcome = welcome;
    }
    public string GetWelcome()
    {
        return _welcome;
    }
    public virtual void points()
    {   

        string readPoints = File.ReadAllText("percentage.txt");
        int values = Int32.Parse(readPoints);
        
        Console.Write($"\nYour Average Percentage: {readPoints}%\n");

        if (values >= 90)
        {
            Console.Write("Your Grade is: A");
        }
        else if (values >= 80)
        {
            Console.Write("Your Grade is: B");
        }
        else if (values >= 70)
        {
            Console.Write("Your Grade is: C");
        }
        else if (values >= 60)
        {
            Console.Write("Your Grade is: D");
        }
        else
        {
            Console.Write("E");
        }

    }
    
    public string GetAnimations()
    {
        List<string>animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        foreach( string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        return _animations;
    }
    
}