public class BreathingActivity : MindRelief
{
    private string _tSleep;

    public BreathingActivity(string tsleep, string welcome,string description, string promptSec) : base(welcome, description, promptSec)
    {
        _tSleep = tsleep;
    }
    
        
    
    public string GettSleep()
    {
        return _tSleep;
    }
    
}