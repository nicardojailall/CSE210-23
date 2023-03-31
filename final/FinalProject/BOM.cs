public class BOM : IntelligentTest
{
    
    private string _infoBOM;

    public BOM(string infoBOM,string welcome) : base (welcome)
    {
        _infoBOM = infoBOM;
    }
    public string GetBOM()
    {
        return _infoBOM;
    }
    public override void points()
    {
        string readPoints = File.ReadAllText("iqBOM.txt");
        int values = Int32.Parse(readPoints);
        Console.Write($"\nYour Book of Mormon Test Percentage: {readPoints}%\n");
    } 
     public void GetBOMTest()
    {
        GetAnimations();
        Console.Clear();
        int points = 0;
        Console.Write("\nWhat is the Book Of Mormon? \nA. the new bible \nB. another testament of Jesust Christ \nC. replacement bible \nD. a new book\n");
        string readOne = Console.ReadLine();
        if (readOne == "B")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nA. How many Books in the Book Of Mormon \nA. 10 \nB. 66 \nC. 33 \nD. 15\n");
        string readTwo = Console.ReadLine();
        if (readTwo == "D")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nWhy was it okay for Nephi to kill Laban? \nA. he needed the brass plates \nB. nephi wanted to kill him \nC. he was constrained by the spirit \nD. he was scared of his father\n");
        string readThree = Console.ReadLine();
        if (readThree == "C")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nWrite at least 50 words about your testimony of the Book Of Mormon\n");
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
        using (StreamWriter outputFile = new StreamWriter("iqBOM.txt"))
        {
            outputFile.Write(percentage);
        }
            string readPoints = File.ReadAllText("percentage.txt");
            int values = Int32.Parse(readPoints);
            int calculate1 = values * 100;
            int calculate2 = percentage * 100;
            int calculate3 = calculate1 + calculate2;
            int totalPercentage = calculate3 / 700;
            
            using (StreamWriter outputFile = new StreamWriter("percentage.txt"))
            {
               outputFile.Write(totalPercentage);
            }
    }

}
