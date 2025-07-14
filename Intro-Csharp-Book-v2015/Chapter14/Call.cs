namespace Chapter14;

public class Call
{
    private DateTime _date;
    private int _callTime;

    public Call(DateTime date, int callTime)
    {
        _date = date;
        _callTime = callTime;
    }

    public string Date
    {
        get { return _date.ToString("dd/MM/yyyy"); }
        set { _date = DateTime.Parse(value); }
    }

    public string TimeStart
    {
        get { return _date.ToString("HH:mm"); }
    }

    public int CallTime
    {
        get { return _callTime; }
        set { _callTime = value; }
    }
}