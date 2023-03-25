public class IT : IntelligentTest
{
    
    private string _infoIT;

    public IT(string infoIT,string welcome) : base (welcome)
    {
        _infoIT = infoIT;
    }
    public string GetIT()
    {
        return _infoIT;
    }
    public override void points()
    {
        string readPoints = File.ReadAllText("iqIT.txt");
        int values = Int32.Parse(readPoints);
        Console.Write($"\nYour ITTest Percentage: {readPoints}%\n");
    } 
     public void GetITTest()
    {
        GetAnimations();
        Console.Clear();
        int points = 0;
        Console.Write("\nWhat does the 's' in HTTPS stand for? \nA. secure \nB. search \nC. send \nD. none of the above\n");
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
        Console.Write("\nIn C# what is the output for '2' +'2'? \nA. 4 \nB. 22 \nC. 2+2 \nD. 2\n");
        string readTwo = Console.ReadLine();
        if (readTwo == "B")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nWhat would a company do if they need to add a new policy in a Domain? \nA. create a Group policy \nB. create a new OU \nC. send an email \nD. inform HR\n");
        string readThree = Console.ReadLine();
        if (readThree == "A")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nWrite at least 50 words about what you like about being in the IT field\n");
        string readFour = Console.ReadLine();
        int wordCount = 0;
        for(int i = 0;i < readFour.Length-1; i++)
        {
            if (readFour[i]  == ' ' && Char.IsLetter(readFour[i+1]) && (i > 0)) 
            {  
                wordCount++;
            }
        }
        wordCount++;
        if (wordCount >= 50)
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
        using (StreamWriter outputFile = new StreamWriter("iqIT.txt"))
        {
            outputFile.Write(percentage);
        }
         
    }

}
