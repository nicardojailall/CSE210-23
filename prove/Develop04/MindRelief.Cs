public class MindRelief
{
    private string _menu1;
    private string _menu2;
    private string _menu3;
    private string _menu4;
    private string _prompt;
    private string _welcome;
    private string _promptSec;
    private string _description;
    private string  _animations;


    public MindRelief(string menu1, string menu2, string menu3, string menu4, string prompt)
    {
        _menu1 = menu1;
        _menu2 = menu2;
        _menu3 = menu3;
        _menu4 = menu4;
        _prompt = prompt;
        

    }
    public string GetMenu()
    {
        return $"{_menu1}{_menu2}{_menu3}{_menu4}{_prompt}";
    }
    
    public MindRelief(string welcome, string description, string promptSec)
    {   
        _welcome = welcome;
        _description = description;
        _promptSec = promptSec;
    }
    public string GetDescription()
    {
        return $"{_welcome}{_description} {_promptSec}";
    }
    public string GetAnimations()
    {
        List<string>animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        foreach( string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        return _animations;
    }
}