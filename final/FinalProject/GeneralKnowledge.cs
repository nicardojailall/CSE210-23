public class GeneralKnowledge : IntelligentTest
{
    private string _inforGeneral;

    public GeneralKnowledge(string inforGeneral,string welcome) : base (welcome)
    {
        _inforGeneral = inforGeneral;
    }
    public string GetGeneral()
    {
        return _inforGeneral;
    }
    public override void points()
    {
        string readPoints = File.ReadAllText("iqGeneral.txt");
        int values = Int32.Parse(readPoints);
        Console.Write($"\nYour General Knowledge Test Percentage: {readPoints}%\n");
    } 
     public void GetGeneralTest()
    {
        GetAnimations();
        Console.Clear();
        int points = 0;
        Console.Write("\nHow many wonders are there? \nA. 7 \nB. 4 \nC. 9 \nD. none\n");
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
        Console.Write("\nA Which is the longest river in the world? \nA. Amazon \nB. Nile \nC. Caribbean \nD Pacific\n");
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
        Console.Write("\nSuriname is located on which continent? \nA. South America \nB. Asia \nC. Europe \nD. Austrailia\n");
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
        Console.Write("\nHow many rings is the Olympic symbol made up of??\nA. 4 \nB. 5\nC. 3 \nD. 9\n");
        string readFour = Console.ReadLine();
        if (readFour == "B")
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
        using (StreamWriter outputFile = new StreamWriter("iqGeneral.txt"))
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