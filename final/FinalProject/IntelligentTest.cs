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
    {   string readPoints = File.ReadAllText("IQ.txt");
        string readPoints1 = File.ReadAllText("iqMaths.txt");
        string readPoints2 = File.ReadAllText("iqBOM.txt");
        string readPoints3 = File.ReadAllText("iqScience.txt");
        string readPoints4 = File.ReadAllText("iqIT.txt");
        string readPoints5 = File.ReadAllText("iqGeneral.txt");
        string readPoints6 = File.ReadAllText("iqEnglish.txt");
        int values = Int32.Parse(readPoints);
        int values1 = Int32.Parse(readPoints1);
        int values2 = Int32.Parse(readPoints2);
        int values3 = Int32.Parse(readPoints3);
        int values4 = Int32.Parse(readPoints4);
        int values5 = Int32.Parse(readPoints5);
        int values6 = Int32.Parse(readPoints6);
        int calculate = values * 100;
        int calculate1 = values * 100;
        int calculate2 = values * 100;
        int calculate3 = values * 100;
        int calculate4 = values * 100;
        int calculate5 = values * 100;
        int calculate6 = values * 100;
        int totalCalculate = calculate + calculate1 + calculate2 + calculate3 + calculate4 + calculate5 + calculate6;
        float totalPercentageAverage = totalCalculate / 700;
        using (StreamWriter outputFile = new StreamWriter("percentage.txt"))
            {
               outputFile.Write(totalPercentageAverage);
            }

        string readPoints0 = File.ReadAllText("percentage.txt");
        int values0 = Int32.Parse(readPoints0);
        
        Console.Write($"\nYour Average Percentage: {totalPercentageAverage}%\n");

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