using System;

class Billing
{
    static void Main()
    {
        Console.Write("Enter product name: ");
        string product = Console.ReadLine();

        Console.Write("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double total = price * quantity;
        double discount = 0;
        double gst;

        if (total > 5000)
        {
            discount = (3 * total) / 100;
            total = total - discount;

            gst = (18 * total) / 100;
        }
        else
        {
            gst = (12 * total) / 100;
        }

        double finalPrice = total + gst;

        Console.WriteLine("\nProduct  : " + product);
        Console.WriteLine("Price    : ₹" + price);
        Console.WriteLine("Quantity : " + quantity);
        Console.WriteLine("Discount : ₹" + discount);
        Console.WriteLine("GST      : ₹" + gst);
        Console.WriteLine("Final Price : ₹" + finalPrice);
    }
}