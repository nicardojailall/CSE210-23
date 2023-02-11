using System;

public class Words
{
    private string _tractRefText;
    private string _prompt;
   

    
    


    public Words()
    {
        _tractRefText = File.ReadAllText("verses.txt");
       
       
    }
    public string GetTextString()
    {
        return _tractRefText;
    }
    public Words(string prompt)
    {
        _prompt = prompt;
    }
    public string GetPromptString()
    {
        return _prompt;
    }
    
    
}   

