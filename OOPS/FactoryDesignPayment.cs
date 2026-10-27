using System;

public interface IPayment
{
    void Pay(double amount);
}

public class GPay : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid Rs." + amount + " using GPay");
    }
}

public class CreditCard : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid Rs." + amount + " using Credit Card");
    }
}

public class Cash : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid Rs." + amount + " using Cash");
    }
}

public class PaymentFactory
{
    public static IPayment GetPayment(string paymentType)
    {
        if (paymentType == "GPay")
            return new GPay();
        else if (paymentType == "CreditCard")
            return new CreditCard();
        else if (paymentType == "Cash")
            return new Cash();
        else
            return null;
    }
}

class FactoryDesignPayment
{
    static void Main()
    {
        Console.Write("Enter payment amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose payment method (GPay/CreditCard/Cash): ");
        string paymentTypes = Console.ReadLine();

        IPayment payment = PaymentFactory.GetPayment(paymentTypes);

        if (payment != null)
            payment.Pay(amount);
        else
            Console.WriteLine("Invalid payment method");
    }
}