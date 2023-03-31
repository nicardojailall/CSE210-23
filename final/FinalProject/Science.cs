public class Science : IntelligentTest
{
    private string _infoScience;

    public Science(string inforScience,string welcome) : base (welcome)
    {
        _infoScience = inforScience;
    }
    public string GetScience()
    {
        return _infoScience;
    }
    public override void points()
    {
        string readPoints = File.ReadAllText("iqScience.txt");
        int values = Int32.Parse(readPoints);
        Console.Write($"\nYour Science Percentage: {readPoints}%\n");
    } 
    public void GetScienceTest()
    {
        GetAnimations();
        Console.Clear();
        int points = 0;
        Console.Write("Who came up with the Theory of Relativity? \nA. Thomas Edison \nB. Isaac Newton \nC. Albert Einstein \nD. Stephen Hawking\n");
        string readOne = Console.ReadLine();
        if (readOne == "C")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nElectrons are smaller than atoms(type 'true' or 'false')? ");
        string readTwo = Console.ReadLine();
        if (readTwo == "true")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nWhat is the hardest substance on earth? \nA. Gold \nB. Silver\nC. Vibranium \nD. Diamond\n");
        string readThree = Console.ReadLine();
        if (readThree == "D")
        {
            points +=1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nHow many bones are in the human body? \nA. 206 \nB. 32 \nC. 1 \nD. 1000\n");
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
        using (StreamWriter outputFile = new StreamWriter("iqScience.txt"))
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