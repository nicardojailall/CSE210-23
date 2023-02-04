using System;
using System.IO; 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Date and time
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        int userNumber = 1;
        //while loop to have the code run until the user decides to exit
        while (userNumber != 5)
        {   
            ////menu items
            Console.Write("\n");
            Console.Write("1.Write:\n");
            Console.Write("2.Display:\n");
            Console.Write("3.Load:\n");
            Console.Write("4.Save:\n");
            
            Console.Write("5.Exit:\n");
            //prompt for input from menu
            Console.Write("Please enter a number:\n");
            string userResponse = Console.ReadLine();
            
            //prompt generator
            Prompts prompts = new Prompts();
                
            prompts._randomGenerator = "";
            //journal class
            Journal journal = new Journal();
            journal._save = " Save text as(txt)";
            
            userNumber = int.Parse(userResponse);
            
            
            
            //if statement to write to journal
            if (userNumber == 1)
            {   
                //prompt generator
                
                Console.WriteLine(prompts._randomGenerator);
                //saving to txt file
                using (StreamWriter outputFile = new StreamWriter("journal.txt"))
                {
                    Console.WriteLine(">");
                    string newEntry= Console.ReadLine();
                    outputFile.WriteLine($"{dateText}: {newEntry}");

                }
        

            }
                
            
            //display txt already input
            

            else if ( userNumber == 2)
            {   
            
                string display = File.ReadAllText("journal.txt");
                Console.WriteLine(display);
            }
            //load saved txt by name
            else if ( userNumber ==3)

            {
                Console.WriteLine("What is the filename?");
                string loadAnswer = Console.ReadLine();
                string path3 = loadAnswer;
                if (File.Exists(path3))
                {
                    string loadTxt = File.ReadAllText(path3);
                    Console.WriteLine(loadTxt);

                    
                    
                }
                
                
            }
            //save txt file to own txt s
           else if (userNumber == 4 )

           {    Entry entry1 = new Entry();
                entry1._retrieveText = "Save text as(txt)";
                Console.WriteLine(entry1._retrieveText);
                string saved = Console.ReadLine();
                
                File.Copy("journal.txt", saved);
                
                
                
           }          
            
             
                
            
            //exiting code
            else if (userNumber == 5)
            {
                Console.WriteLine("Good Bye");
            }
            //message for user to try again if any number other than reqired was input
            else if (userNumber != 1-5)
            {
                Console.WriteLine("try again");
            }
            
        }

        



    }

        
  

}