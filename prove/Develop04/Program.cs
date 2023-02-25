using System;


class Program
{
    //private static System.Timers.Timer aTimer;
    static void Main(string[] args)
    {
        int input = 1;
        while (input != 4)
        {
            MindRelief mR = new MindRelief("\n1.Start Breathing activity\n", "2.Start Reflecting activity\n", "3.Start Listin activity\n", "4.Quit\n", "\nSelect a choice from Menu\n");
            Console.Write(mR.GetMenu());

            string receivePrompt = Console.ReadLine();
            input = int.Parse(receivePrompt);
            if (input == 1)
            {
                Console.Write("\nyes\n");
                BreathingActivity bA1 = new BreathingActivity("\nWell Done\n", "\nWelcome to the Breathing Activity\n",
                "\nThis activity will help you relax by slowly breathing in and out. Clear your mind\n", "\nHow long,in seconds would you like for your session\n");
                Console.Write(bA1.GetDescription());

                int timer1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nGet Ready...\n");
                Console.Write(mR.GetAnimations());
                int eachSession = timer1 / 6;

                for (var i = eachSession; i <= eachSession; i--)
                {
                    Thread.Sleep(2000);
                    Console.Write("\rBreathe in : " + i);

                    if (i == 0)
                    {
                        Console.Write(bA1.GettSleep());
                        break;
                    }

                }
            }
            else if (input == 2)
            {

                ReflectingActivity rA = new ReflectingActivity("\nConsider the following\n", "\nWhen you have something in mind type (begin):\n", "\nNow ponder in each question and reflect on your experiences\n", "\nWelcome to the Reflecting Activity\n",
                "\nThis activity will help you reflect on past experiences and remember how you felt. Clear your mind and then lets begin\n", "\nHow long,in seconds would you like for your session\n");
                Console.Write(rA.GetDescription());
                int timer2 = Convert.ToInt32(Console.ReadLine());
                int eachSession2 = timer2 / 4;
                int rAtimer = eachSession2 * 1000;
                Console.Write("\nGet Ready...\n");
                Console.Write(mR.GetAnimations());
                Console.Write(rA.GetAlert());
                Console.Write(rA.GetPromptQ());
                Console.Write(rA.GettoContinue());
                string readPrompt = Console.ReadLine();
                if (readPrompt == "begin")
                {
                    Console.Write(rA.GetbeginPondering());
                    for (var i = eachSession2; i <= eachSession2; i--)
                    {
                        Thread.Sleep(2000);
                        Console.Write("\rBegin in : " + i);

                        if (i == 0)
                        {
                            Console.Write("\n");
                            Console.Write($"\n{rA.GetPromptQ1()}");
                            Thread.Sleep(rAtimer);

                            Console.Write($"\n{rA.GetPromptQ1()}");
                            Thread.Sleep(rAtimer);
                            Console.Write($"\n{rA.GetPromptQ1()}");
                            Thread.Sleep(rAtimer);
                            Console.Write("\n Well Done!!\n You have completed another Reflecting Activity\n");
                            break;
                        }
                        else if (i == 0)
                        {
                            Console.Write("\n Well Done!!\n You have completed another Reflecting Activity\n");
                            break;
                        }

                    }

                }


            }
            else if (input == 3)
            {

                ListingActivity lA = new ListingActivity("\nList as many responses as you can\n", "\nWelcome to the Listing Activity\n",
                "\nListing activity will help you reflect on good thingsin your life. List as many as you can.\n", "\nHow long,in seconds would you like for your session\n");
                Console.Write(lA.GetDescription());
                int timer3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nGet Ready...\n");
                Console.Write(mR.GetAnimations());
                Console.Write(lA.GetListResponses());
                Console.Write(lA.GetResponses());
                int ten = 9;
                for (var i = ten; i <= ten; i--)
                {
                    Thread.Sleep(2000);
                    Console.Write("\rBegin in : " + i);
                    if (i == 1)
                    {

                        Console.Write("\n>");
                        string read = Console.ReadLine();
                    }
                    else if (i == 0)
                    {
                        break;
                    }
                }
            }

            else if (input == 4)
            {
                Console.Write("\nbye\n");
            }

        }
    }
}