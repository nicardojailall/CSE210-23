using System;

public class Referrence
{
    private string _text;
    private string _book;
    private string _verse;
    
    
    public Referrence()
    {
        _text = "8 Remember the sabbath day, to keep it holy. 9 Six days shalt thou labour, and do all thy work:\n";
       
        
    }
    public Referrence(string text0)
    {
        _text = text0;
    }
    public string GetText0()
    {
        return _text;
    }
   

    public Referrence( string book,string verse)
    {
        _book = book;
        _verse = verse;
    }
    public string GetBookString()
    {
        return _book;
    }
    public string GetVerseString()
    {
        return _verse;
    }
    
}