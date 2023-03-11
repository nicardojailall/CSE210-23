using System;


class Program
{
    static void Main(string[] args)
    {   ///weekly goals a week
       
        
        
        Goals goals = new Goals("Points: ");
        Console.Write(goals.GetPoints());
        int input = 0;
        
        while( input != 6)
        {   
            Console.Write("\nMenu Options:\n   1.Create\n   2.List Goals\n   3.Save Goals\n   4.Load Goals\n   5.Record Event\n   6.Quit\nSelect a choice from the menu: \n");
            string menu = Console.ReadLine();
            input = int.Parse(menu);
            
            
            if (input ==1)
            {   
                int inputt = 0;
                while (input !=4)
                {   
                    Console.Write("\nThe types of Goals are: \n  1.Simple Goal\n  2.Eternal Goal\n  3.Checklist\n  4.Exit\nWhat type of goal would you like to create? ");
                    string menuReturn = Console.ReadLine();
                    inputt = int.Parse(menuReturn);
                    
        
                    if ( inputt == 1)
                    {
                        SimpleGoals sGoals = new SimpleGoals("Points: ");
                        sGoals.GetSimpleGoals();
                        sGoals.GetPoints();
                        
                    }
                    else if (inputt == 2)
                    {
                        checkListGoal cListGoals = new checkListGoal();
                        cListGoals.GetCheckListGoals();
                    }
                    else if (inputt == 3)
                    {
                        EternalGoals eGoals = new EternalGoals();
                        eGoals.GetEternalGoals();
                    }
                    
                    else if (inputt == 4)
                    {
                        Console.Write("Thank you");
                        break;
                    }
                    
                }
            }
            else if (input == 2)
            {
                
                goals.GetListGoals();
            }
            else if (input == 3)
            {
                
                goals.GetSavedGoals();
            }
            else if (input == 4)
            {
                
                goals.GetLoadGoals();
            }
            else if(input == 5)
            {
                RecordGoals rGoals= new RecordGoals("Points:");
                rGoals.GetRecordGoals();
                rGoals.GetPoints();
            }
            else if (input ==6)
            {
                Console.Write("Thank you");
            }
        }
    }
    
}