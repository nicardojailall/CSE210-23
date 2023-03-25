public class Math : IntelligentTest
{   
    private string _infoMath;

    public Math(string infoMath, string welcome) : base (welcome)
    {
        _infoMath = infoMath;
    }
    public string GetMath()
    {
        return _infoMath;
    }
    public override void points()
    {
        string readPoints1 = File.ReadAllText("iqMaths.txt");
        int values1 = Int32.Parse(readPoints1);
        Console.Write($"\nYour Math Percentage: {readPoints1}%\n");
    } 
    public void GetMaths()
    {   
        GetAnimations();
        Console.Clear();
        int points = 0;
        Console.Write("10 + 15 * 3: ");
        string mathOne = Console.ReadLine();
        if (mathOne =="55")
        {
            points += 1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nI am twice as old as my youngest brother. If the difference between our ages is 15 years.\nHow old is my youngest brother?\n A. 10\n B. 15\n C. 25\n D. 30\n");
        string mathTwo = Console.ReadLine();
        if (mathTwo =="B")
        {
            points += 1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nSue receives a base salary of $90 weekly plus a 12% commission on all sales.\nSue had $3,000 in sales this week. How much did she make total?\n A. $375\n B. $450\n C. $480\n D. $510\n");
        string mathThree = Console.ReadLine();
        if (mathThree =="B")
        {
            points += 1;
            Console.Write("Correct");
        }
        else
        {
            Console.Write("Incorrect");
        }
        Console.Write("\nWhat is the value of Pi to four individual decimal places?: ");
        string mathFour = Console.ReadLine();
        if (mathFour =="3.1416")
        {
            points += 1;
            Console.Write("Correct\n");
        }
        else
        {
            Console.Write("Incorrect\n");
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
        using (StreamWriter outputFile = new StreamWriter("iqMaths.txt"))
        {
            outputFile.Write(percentage);
        }
           
    }
}