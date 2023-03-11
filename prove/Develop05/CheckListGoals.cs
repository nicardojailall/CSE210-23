public class checkListGoal
{
    public void GetCheckListGoals()
    {
        using (StreamWriter outputFile2 = File.AppendText("newGoals.txt"))
                {
                    Console.Write("What is the name of your goal? \n");
                    string checkListGoal = Console.ReadLine();
                    Console.Write("What is a short description of your goal? \n");
                    string description = Console.ReadLine();
                    Console.Write("How many points do you want for this goal? \n");
                    string goalPoints = Console.ReadLine();
                    
                    outputFile2.WriteLine($"CheckList Goals  3. [] {checkListGoal}  ({description}) :{goalPoints}\n");
                }
    }
}