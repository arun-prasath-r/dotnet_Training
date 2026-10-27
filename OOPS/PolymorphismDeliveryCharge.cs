using System;

class DeliveryService
{
    public double CalculateDeliveryCharge(double distance)
    {
        return distance * 10;
    }

    public double CalculateDeliveryCharge(double distance, double weight)
    {
        return (distance * 10) + (weight * 5);
    }

    public double CalculateDeliveryCharge(double distance, double weight, bool express)
    {
        double charge = (distance * 10) + (weight * 5);

        if (express == true)
            charge = charge + 100;

        return charge;
    }
}

class Program
{
    static void Main()
    {
        DeliveryService obj = new DeliveryService();

        Console.Write("Enter distance in km: ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Charge by distance: " + obj.CalculateDeliveryCharge(distance));

        Console.Write("Enter weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Charge by distance and weight: " + obj.CalculateDeliveryCharge(distance, weight));

        Console.Write("Express delivery? (true/false): ");
        bool express = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Final delivery charge: " + obj.CalculateDeliveryCharge(distance, weight, express));
    }
}