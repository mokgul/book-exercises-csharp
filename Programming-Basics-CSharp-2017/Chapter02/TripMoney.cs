using System.Globalization;

namespace Chapter02;

public static class TripMoney
{
    public static void Convert()
    {
        var ci = CultureInfo.InvariantCulture;
        
        long bitcoins = long.Parse(Console.ReadLine()!.Trim(), ci);
        double yuans = double.Parse(Console.ReadLine()!.Trim(), ci);
        double commissionPercent = double.Parse(Console.ReadLine()!.Trim(), ci);
        
        const double BtcToBgn = 1168.0;
        const double YuanToUsd = 0.15;
        const double UsdToBgn = 1.76;
        const double EurToBgn = 1.95;
        
        double bgnFromBtc = bitcoins * BtcToBgn;
        double bgnFromYuan = yuans * YuanToUsd * UsdToBgn; // yuans * 0.264
        double totalBgn = bgnFromBtc + bgnFromYuan;
        
        double euros = totalBgn / EurToBgn;
        
        double commission = commissionPercent / 100.0;
        double result = euros * (1.0 - commission);
        
        Console.WriteLine(result.ToString(ci));
    }
}