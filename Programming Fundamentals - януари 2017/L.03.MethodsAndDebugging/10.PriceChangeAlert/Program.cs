using System;

public class PriceChangeAlert
{
    public static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double significantDifferance = double.Parse(Console.ReadLine());
        double oldPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double differance = GetDifferance(oldPrice, currentPrice);

            bool pricesAreSignificantlyDifferent = IsThereDifferance(differance, significantDifferance);

            string message = GetMessage(currentPrice, oldPrice, differance, pricesAreSignificantlyDifferent);
            Console.WriteLine(message);

            oldPrice = currentPrice;
        }
    }

    public static string GetMessage(double currentPrice, double oldPrice, double differance, bool pricesAreSignificantlyDifferent)
    {
        string massage = string.Empty;

        if (differance == 0)
        {
            massage = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!pricesAreSignificantlyDifferent)
        {
            massage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", oldPrice, currentPrice, differance * 100);
        }
        else if (pricesAreSignificantlyDifferent && (differance > 0))
        {
            massage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", oldPrice, currentPrice, differance * 100);
        }
        else if (pricesAreSignificantlyDifferent && (differance < 0))
        {
            massage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", oldPrice, currentPrice, differance * 100);
        }

        return massage;
    }

    public static bool IsThereDifferance(double differance, double tolerance)
    {
        if (Math.Abs(differance) >= tolerance)
        {
            return true;
        }

        return false;
    }

    public static double GetDifferance(double oldPrice, double currentPrice)
    {
        double differance = (currentPrice - oldPrice) / oldPrice;
        return differance;
    }
}
