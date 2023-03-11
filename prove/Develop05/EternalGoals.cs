class EternalGoals
{
    public void GetEternalGoals()
    {
       using (StreamWriter outputFile1 = File.AppendText("newGoals.txt"))
         {
            Console.Write("What is the name of your goal? \n");
            string eternalGoal = Console.ReadLine();
             Console.Write("What is a short description of your goal? \n");
            string description = Console.ReadLine();
            Console.Write("How many points do you want for this goal? \n");
            string goalPoints = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for bonus points? \n");
            string bonusGoals = Console.ReadLine();
            Console.Write("What is the bonus for accomplishing it that many times? \n");
            string bonusPoints = Console.ReadLine();
                    
            outputFile1.WriteLine($"Eternal Goals:  2. [] {eternalGoal}  ({description}) --Currently completed: 0/{bonusGoals};{goalPoints}--Bonus points {bonusPoints}\n");
        }        
    }
}