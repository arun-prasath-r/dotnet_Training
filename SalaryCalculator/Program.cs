using System;
class Salary
{
    static void Main()
    {
        Console.Write("Enter total working days: ");
        int totalDays = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter total salary: ");
        double totalSalary = Convert.ToDouble(Console.ReadLine());

        double oneDaySalary = totalSalary / totalDays;

        Console.Write("Enter days worked: ");
        int daysWorked = Convert.ToInt32(Console.ReadLine());

        double salaryEarned = oneDaySalary * daysWorked;

        Console.Write("Enter your experience in years: ");
        int experience = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nTotal working days : " + totalDays);
        Console.WriteLine("Total salary       : Rs." + totalSalary);
        Console.WriteLine("Salary per day     : Rs." + oneDaySalary);
        Console.WriteLine("Days worked        : " + daysWorked);
        Console.WriteLine("Salary earned      : Rs." + salaryEarned);

        double increment = 0;
        double baseSalary = 15000;

        if (experience >= 5)
        {
            increment = baseSalary * 10 / 100;
        }
        else if (experience >= 3)
        {
            increment = baseSalary * 5 / 100;
        }
        else if (experience >= 1)
        {
            increment = baseSalary * 2 / 100;
        }
        else
        {
            increment = 0;
        }

        double finalSalary = baseSalary + increment;

        Console.WriteLine("Increment          : Rs." + increment);
        Console.WriteLine("Final salary       : Rs." + finalSalary);
    }
}