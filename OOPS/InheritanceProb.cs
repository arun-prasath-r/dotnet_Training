using System;

class College
{
    public string collegeName = "ABC College";
    public string location = "Chennai";

    public void ShowCollegeDetails()
    {
        Console.WriteLine("College Name: " + collegeName);
        Console.WriteLine("Location: " + location);
    }
}

class ClgStudents : College
{
    public void ShowStudentDetails()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter roll number: ");
        int rollNo = Convert.ToInt32(Console.ReadLine());

        ShowCollegeDetails();

        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Roll Number: " + rollNo);
    }
}

class Staff : College
{
    public void ShowStaffDetails()
    {
        Console.Write("Enter staff name: ");
        string name = Console.ReadLine();

        Console.Write("Enter staff ID: ");
        int staffId = Convert.ToInt32(Console.ReadLine());

        ShowCollegeDetails();

        Console.WriteLine("Staff Name: " + name);
        Console.WriteLine("Staff ID: " + staffId);
    }
}

class InheritanceProb
{
    static void Main()
    {
        Console.WriteLine("1. Student");
        Console.WriteLine("2. Staff");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            ClgStudents s = new ClgStudents();
            s.ShowStudentDetails();
        }
        else
        {
            Staff s = new Staff();
            s.ShowStaffDetails();
        }
    }
}