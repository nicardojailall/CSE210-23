using System;

public class Program
{
    static void Main(string[] args)
    {   
       
        int input = 0;
        while (input !=8)
        {   
            Console.Write("***********************************************************");
            IntelligentTest average = new IntelligentTest("\nWelcome to the Intelligent Test Program\n");
            IntelligentTest memoryPoints = new Memory("","");
            IntelligentTest mathPoints = new Math("","");
            IntelligentTest sciencePoints = new Science("","");
            IntelligentTest englishPoints = new English("","");
            IntelligentTest bomPoints = new BOM("","");
            IntelligentTest itPoints = new IT("","");
            IntelligentTest generalPoints = new GeneralKnowledge("","");
            average.points();
            Console.Write(average.GetWelcome());
            Console.Write("\n1. Memory\n2. Math\n3. Science\n4. English \n5. Book Of Mormon \n6. IT \n7. General Knowledge \n8. Exit\n Select a Quiz\n");//CrossWord //Riddles-https://therealschool.in/blog/maths-trick-question-riddles-answers-interesting-math-kids/
            string menu = Console.ReadLine();
            input = int.Parse(menu);
             if (input == 1)
             {
                Memory memory = new Memory("Welcome to the Memory Test\n", "Memorise the below text\n");
                Console.Write(memory.GetWelcome());
                Console.Write(memory.GetMemorise());
                memory.GetMemory(); 
                //average.points();
                memoryPoints.points(); 
             }
            else if (input == 2)
            {
                Math math = new Math("Answer the below questions\n", "Welcome to the Math Test\n");
                Console.Write(math.GetWelcome());
                Console.Write(math.GetMath());
                math.GetMaths();
                mathPoints.points();
                
            }
            else if (input == 3)
            {
                Science science = new Science("Answer the below questions\n", "Welcome to the Science Test\n");
                Console.Write(science.GetWelcome());
                Console.Write(science.GetScience());
                science.GetScienceTest();
                sciencePoints.points();
            }
            else if (input == 4)
            {
                English english = new English("Answer the below questions\n", "Welcome to the English Test\n");
                Console.Write(english.GetWelcome());
                Console.Write(english.GetEnglish());
                english.GetEnglishTest();
                englishPoints.points();
            }
            else if (input == 5)
            {
                BOM bom = new BOM("Answer the below questions\n", "Welcome to the Book Of Mormon Test\n");
                Console.Write(bom.GetWelcome());
                Console.Write(bom.GetBOM());
                bom.GetBOMTest();
                bomPoints.points();
            }
            else if (input == 6)
            {
                IT it = new IT("Answer the below questions\n", "Welcome to the IT Test\n");
                Console.Write(it.GetWelcome());
                Console.Write(it.GetIT());
                it.GetITTest();
                itPoints.points();
            }
            else if (input == 7)
            {
                GeneralKnowledge general = new GeneralKnowledge("Answer the below questions\n", "Welcome to the General Knowledge Test\n");
                Console.Write(general.GetWelcome());
                Console.Write(general.GetGeneral());
                general.GetGeneralTest();
                generalPoints.points();
            }
            else
            {
                Console.Write("GoodBye");
            }
        }
        
        
       
        
    

        
        
       
        
        
        
        
    }
}