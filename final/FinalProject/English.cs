public class English : IntelligentTest
{
    private string _infoEnglish;

    public English(string inforEnglish,string welcome) : base (welcome)
    {
        _infoEnglish = inforEnglish;
    }
    public string GetEnglish()
    {
        return _infoEnglish;
    }
    public override void points()
    {
        string readPoints = File.ReadAllText("iqEnglish.txt");
        int values = Int32.Parse(readPoints);
        Console.Write($"\nYour English Test Percentage: {readPoints}%\n");
    } 
     public void GetEnglishTest()
    {
        GetAnimations();
        Console.Clear();
        int points = 0;
        Console.Write("\nWhich is the incorrect abbreviation? \nA. they'are\nB. aren't \nC. isn't \nD. wasn't\n");
        string readOne = Console.ReadLine();
        if (readOne == "A")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nA female pig is called? \nA. a sows \nB. a lamb \nC. pepper pig \nD boar\n");
        string readTwo = Console.ReadLine();
        if (readTwo == "A")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nWhich is the corret vowels? \nA. a, e, o, u \nB. a, e, i, o, u \nC. a, o, u, t \nD. a, e, i, u\n");
        string readThree = Console.ReadLine();
        if (readThree == "B")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nWhat is the plural term for equiptment?\nA. equiptment \nB. equiptments \nC. equiptment's \nD.equiptments'\n");
        string readFour = Console.ReadLine();
        if (readFour == "A")
        {
            points +=1;
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
        using (StreamWriter outputFile = new StreamWriter("iqEnglish.txt"))
        {
            outputFile.Write(percentage);
        }
           
    }

}