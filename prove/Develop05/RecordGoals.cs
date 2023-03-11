class RecordGoals: Goals
{   
    public RecordGoals(string points) :base(points)
    {

    }
    
    public void GetRecordGoals()//Record Goals
    {
      
        //string display = File.ReadAllText("newGoals.txt");
       
            
        
        string lineOne = System.IO.File.ReadAllLines("newGoals.txt").Skip(1).Take(1).First();
        string lineTwo = System.IO.File.ReadAllLines("newGoals.txt").Skip(2).Take(1).First();
        string lineThree = System.IO.File.ReadAllLines("newGoals.txt").Skip(3).Take(1).First();
        
        Console.Write($"\n The Goals are:\n{GetPoints()} \n1.[] {lineOne}\n2.[] {lineTwo}\n3.[] {lineThree}\nWhich goal did you accomplish\n");
         string read = Console.ReadLine();
         if (read == "1")
         {

         }   
            
          
    }
}