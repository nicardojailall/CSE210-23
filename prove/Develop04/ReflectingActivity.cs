using System;

public class ReflectingActivity : MindRelief
{   
    private string _promptQ;
    private string _promptQ1;
    private string _alert;
    private string _toContinue;
    private string _beginPondering;
    public ReflectingActivity( string alert, string toContinue,string beginPondering, string welcome,string description, string promptSec) : base(welcome, description, promptSec)
    {
        _alert = alert;
        _toContinue = toContinue;
        _beginPondering = beginPondering;
    }
    public string GetPromptQ()
    {   
        
        Random rand = new Random();
        List<string> promtpQ = new List<string>();
        promtpQ.Add("\n....Think of a time that did service for someone!\n");
        promtpQ.Add("\n....What scripture really sticks out to you?\n");
        promtpQ.Add("\n....What is the last principle of the Gospel your worked on ?\n");
        promtpQ.Add("\n....How does going weekly to church Benifit you?\n");
        promtpQ.Add("\n....What are the benifits you got from being obedient?\n");
        

        int index = rand.Next(promtpQ.Count);
        Console.WriteLine(promtpQ[index]);
        return _promptQ;
    }
    public string GetAlert()
    {
        return _alert;
    }
    public string GettoContinue()
    {
        return _toContinue;
    }
    public string GetbeginPondering()
    {
       return  _beginPondering; 
    }
    public string GetPromptQ1()
    {
        Random rand = new Random();
        List<string> promtpQ1 = new List<string>();
        promtpQ1.Add("\n....How did this make you feel? \n");
        promtpQ1.Add("\n....How can this help you in your life? \n");
        promtpQ1.Add("\n....Has this Helped you in your life? \n");
        promtpQ1.Add("\n....How can this help someone else? \n");
        promtpQ1.Add("\n....How is this helping you become a better person?\n");
        promtpQ1.Add("\n....Are you eager to become better from your reflections?\n");

        int index = rand.Next(promtpQ1.Count);
        Console.WriteLine(promtpQ1[index]);
        return _promptQ1;
    }
}