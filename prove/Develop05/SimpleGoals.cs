class SimpleGoals:Goals
{   
    public SimpleGoals(string points) :base(points)
    {

    }
    
    
    
    public void GetSimpleGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("newGoals.txt"))
        {   
                    
            Console.Write("What is the name of your goal? \n");
            string simpleGoal = Console.ReadLine();
            Console.Write("What is a short description of your goal? \n");
            string description = Console.ReadLine();
            Console.Write("How many points do you want for this goal? \n");
            string goalPoints = Console.ReadLine();
                    
            outputFile.WriteLine($"{GetPoints()}\nSimple Goal:  1. [] {simpleGoal}  ({description});{goalPoints}\n");
        }      
    }
}