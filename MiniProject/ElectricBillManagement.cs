using System;

class ElectricityBill
{
    public int customerId;
    public string customerName;
    public int units;
    public double bill;

    public ElectricityBill(int id, string name, int u)
    {
        customerId = id;
        customerName = name;
        units = u;
        bill = 0;
    }

    public void CalculateBill()
    {
        if (units <= 100)
            bill = units * 1.5;
        else if (units <= 200)
            bill = (100 * 1.5) + ((units - 100) * 2.5);
        else if (units <= 300)
            bill = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
        else
            bill = (100 * 1.5) + (100 * 2.5) + (100 * 4) + ((units - 300) * 6);

        bill = bill + 100;

        if (bill > 1000)
            bill = bill + (bill * 0.05);
    }

    public void DisplayBill()
    {
        Console.WriteLine("\nCustomer ID: " + customerId);
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Units Consumed: " + units);
        Console.WriteLine("Total Bill: Rs." + bill);

        if (bill <= 500)
            Console.WriteLine("Payment Category: Normal");
        else
            Console.WriteLine("Payment Category: High");
    }
}

class ElectricBillManagement
{
    static void Main()
    {
        int count;
        double totalRevenue = 0;

        Console.Write("Enter number of customers: ");
        count = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine("\nEnter details for customer " + i);

            Console.Write("Enter Customer ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());

            ElectricityBill obj = new ElectricityBill(id, name, units);

            obj.CalculateBill();
            obj.DisplayBill();

            totalRevenue = totalRevenue + obj.bill;
        }

        Console.WriteLine("\nTotal Revenue: Rs." + totalRevenue);
        Console.WriteLine("Total Customers Processed: " + count);
    }
}