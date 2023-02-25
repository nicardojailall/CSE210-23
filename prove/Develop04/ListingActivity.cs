using System;

public class ListingActivity : MindRelief
{
    private string _listResponses;
    private string _responses;
    

    
    public ListingActivity(string listResponses, string welcome,string description, string promptSec) : base(welcome, description, promptSec)
    {
        _listResponses = listResponses;
    }
    public string GetListResponses()
    {
        return _listResponses;
    }
    public string GetResponses()
    {
        Random rand = new Random();
        List<string> responses = new List<string>();
        responses.Add("\n....What are your priorities? \n");
        responses.Add("\n....When do you pray? \n");
        responses.Add("\n....List of Ten Commandments? \n");
        

        int index = rand.Next(responses.Count);
        Console.WriteLine(responses[index]);
        return _responses;
    }
}   
