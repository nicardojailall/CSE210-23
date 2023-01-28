using System;
using System.IO; 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Date and time
        string updateTextFile = @"C:\Users\spc184987\OneDrive - Saipem\Documents\Jan2023\CSE210-23\prove\Develop02\updateEntry.txt";
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        int userNumber = 1;
        //while loop to have the code run until the user decides to exit
        while (userNumber != 7)
        {   
            ////menu items
            Console.Write("\n");
            Console.Write("1.Write:\n");
            Console.Write("2.Display:\n");
            Console.Write("3.Load:\n");
            Console.Write("4.Save:\n");
            Console.Write("5.Update Previous Entry:\n");
            Console.Write("6.Save Update:\n");
            Console.Write("7.Exit:\n");
            //prompt for input from menu
            Console.Write("Please enter a number:\n");
            string userResponse = Console.ReadLine();
            
            //prompt generator
            Prompts prompts = new Prompts();
                
            prompts._randomGenerator = "";
            //journal class
            Journal journal = new Journal();
            journal._save = " Save text as(txt)";
            journal._path1= @"C:\Users\spc184987\OneDrive - Saipem\Documents\Jan2023\CSE210-23\prove\Develop02\journal.txt";
            userNumber = int.Parse(userResponse);
            Entry entry = new Entry();
            entry._retrievePrevious = File.ReadAllText(journal._path1);
            entry._retrieveText = journal._save;
            //if statement to write to journal
            if (userNumber == 1)
            {   
                //prompt generator
                
                Console.WriteLine(prompts._randomGenerator);
                //saving to txt file
                using (StreamWriter outputFile = new StreamWriter(journal._path1))
                {
                    Console.WriteLine(">");
                    string newEntry= Console.ReadLine();
                    outputFile.WriteLine($"{dateText}: {newEntry}");

                }
                
            }
            //display txt already input
            else if ( userNumber == 2)
            {   
                Console.WriteLine(entry._retrievePrevious);
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

           {   
                Console.WriteLine(entry._retrieveText);
                string saved = Console.ReadLine();
                File.Copy(journal._path1, saved);
           }          
            else if (userNumber == 5)
            {   
                
                Console.WriteLine(prompts._randomGenerator);
                using (StreamWriter outputFile = new StreamWriter(updateTextFile))
                {
                    
                   Console.WriteLine(">");
                    string updatedEntry= Console.ReadLine();
                    outputFile.WriteLine($"{dateText}: {updatedEntry}"); 
                    //Console.WriteLine("Text name to update to?");
                    //string updateTxt = Console.ReadLine();
                    //File.AppendAllText(updateTextFile, updateTxt);
                    //Console.WriteLine(File.ReadAllText(updateTxt));
                }
                
            }
            else if (userNumber == 6)
            {   
                
                Console.WriteLine("Text name to update to?");
                string updateTxt = Console.ReadLine();
                
                File.AppendAllText(updateTextFile, updateTxt);
                Console.WriteLine(File.ReadAllText(updateTxt));
            }
                
                
            
            //exiting code
            else if (userNumber == 7)
            {
                Console.WriteLine("Good Bye");
            }
            //message for user to try again if any number other than reqired was input
            else if (userNumber != 1-7)
            {
                Console.WriteLine("try again");
            }
            
        }

        



    }

        
  

}