namespace Chapter09;

public static class PassionShopping
{
    public static void Solve()
    {
        double money = double.Parse(Console.ReadLine());
        string command;

        // Чакаме mall.Enter
        while ((command = Console.ReadLine()) != "mall.Enter") ;

        int purchases = 0;

        while ((command = Console.ReadLine()) != "mall.Exit")
        {
            foreach (char action in command)
            {
                double price = 0;
                bool isPurchase = true;

                if (char.IsUpper(action))
                {
                    price = action * 0.5;
                }
                else if (char.IsLower(action))
                {
                    price = action * 0.3;
                }
                else if (action == '%')
                {
                    if (money > 0)
                    {
                        money /= 2;
                        purchases++;
                    }
                    isPurchase = false;
                }
                else if (action == '*')
                {
                    money += 10;
                    isPurchase = false;
                }
                else
                {
                    price = action;
                }

                if (isPurchase && price > 0)
                {
                    if (money >= price)
                    {
                        money -= price;
                        purchases++;
                    }
                }
            }
        }

        if (purchases == 0)
        {
            Console.WriteLine($"No purchases. Money left: {money:F2} lv.");
        }
        else
        {
            Console.WriteLine($"{purchases} purchases. Money left: {money:F2} lv.");
        }
    }
}