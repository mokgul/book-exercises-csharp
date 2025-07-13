using System.Text;

namespace Chapter14;

public class Phone
{
    private string _model;
    private string _manufacturer;
    private double _price;
    private string _owner;
    private Battery _battery;
    private Display _display;

    private static string _nokiaN95;
    
    public Phone(string model, string manufacturer, Battery battery, Display display)
    {
        _model = model;
        _manufacturer = manufacturer;
        _battery = battery;
        _display = display;
    }

    public Phone(string model, string manufacturer, Battery battery, Display display, string owner) : this(model,
        manufacturer, battery, display)
    {
        _owner = owner;
    }

    public Phone(string model, string manufacturer, Battery battery, Display display, double price) :
        this(model, manufacturer, battery, display)
    {
        _price = price;
    }

    public Phone(string model, string manufacturer, Battery battery, Display display, string owner, double price)
        : this(model, manufacturer, battery, display)
    {
        _owner = owner;
        _price = price;
    }

    public static string NokiaN95
    {
        get => _nokiaN95;
        set => _nokiaN95 = value;
    }
    
    public string Model
    {
        get => _model;
        set => _model = value;
    }

    public string Manufacturer
    {
        get => _manufacturer;
        set => _manufacturer = value;
    }

    public double Price
    {
        get => _price;
        set => _price = value;
    }

    public string Owner
    {
        get => _owner;
        set => _owner = value;
    }

    public Battery Battery
    {
        get => _battery;
        set => _battery = value;
    }

    public Display Display
    {
        get => _display;
        set => _display = value;
    }
    
    public void GetInfo()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Model: {_model}\n");
        sb.Append($"Manufacturer: {_manufacturer}\n");
        sb.Append($"Price: {Price}\n");
        sb.Append($"Owner: {_owner}\n");
        sb.Append($"Battery: \n");
        sb.Append($"Battery Model: {_battery.Model}\n");
        sb.Append($"Battery Idle Time: {_battery.IdleTime}\n");
        sb.Append($"Battery Hours Talk: {_battery.HoursTalk}\n");
        sb.Append($"Battery Type: {_battery.Type}\n");
        sb.Append($"Display: \n");
        sb.Append($"Display size: {_display.Size}\n");
        sb.Append($"Display colors: {_display.Colors}\n");
        Console.WriteLine(sb.ToString());
    }
}

public class Battery
{
    private string _model;
    private double _idleTime;
    private double _hoursTalk;
    private BatteryType _type;

    public Battery(string model, BatteryType type)
    {
        _model = model;
        _type = type;
        _idleTime = 0;
        _hoursTalk = 0;
    }

    public string Model
    {
        get => _model;
        set => _model = value;
    }

    public double IdleTime
    {
        get => _idleTime;
        set => _idleTime = value;
    }

    public double HoursTalk
    {
        get => _hoursTalk;
        set => _hoursTalk = value;
    }

    public BatteryType Type
    {
        get => _type;
        set => _type = value;
    }
}

public class Display
{
    public double _size;
    public string _colors;

    public Display(string colors, double size)
    {
        _size = size;
        _colors = colors;
    }

    public string Colors
    {
        get => _colors;
        set => _colors = value;
    }

    public double Size
    {
        get => _size;
        set => _size = value;
    }
}