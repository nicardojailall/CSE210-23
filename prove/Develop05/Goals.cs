public  class Goals
{
    private  string _points;
    
    

    public Goals(string points)
    {
        _points = points;
    }
    
    public string GetPoints()
    {
        return _points;
    }
    public void GetListGoals()
    {   
        Console.Write("The Goals are:\n");
        string display = File.ReadAllText("newGoals.txt");
        
        //Console.WriteLine(display);
        string[]lines = System.IO.File.ReadAllLines("newGoals.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            string fWord = parts[0];
            
            Console.Write(fWord);
        }
        
    }
    public void GetSavedGoals()
    {
        Console.WriteLine("What is the filename for the goal file(txt)?");
        string saveGoals = Console.ReadLine();
        File.Copy("newGoals.txt", saveGoals);
    }
    
    public void GetLoadGoals()
    {
        Console.Write("What is the filename for the goal file?  ");
        string getGoal = Console.ReadLine();
        string loadGoal = File.ReadAllText(getGoal);
        //File.Copy(getGoal, "newGoals.txt");
        System.IO.File.WriteAllText("newGoals.txt",loadGoal);
    }

}