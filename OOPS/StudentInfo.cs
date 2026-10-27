using System;

class Student
{
    public void ShowStudentDetails(string name, int rollNo, int tamil, int english, int maths)
    {
        Console.WriteLine("\nSTUDENT DETAILS");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll Number: " + rollNo);
        Console.WriteLine("Tamil: " + tamil);
        Console.WriteLine("English: " + english);
        Console.WriteLine("Maths: " + maths);
    }

    public int CalculateTotal(int tamil, int english, int maths)
    {
        return tamil + english + maths;
    }

    public double CalculateAverage(int total)
    {
        return total / 3.0;
    }

    public void DisplayGrade(double average)
    {
        if (average >= 90)
            Console.WriteLine("Grade: A");
        else if (average >= 75)
            Console.WriteLine("Grade: B");
        else if (average >= 50)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: Fail");
    }
}

class StudentInfo
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter roll number: ");
        int rollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Tamil marks: ");
        int tamil = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter English marks: ");
        int english = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        int maths = Convert.ToInt32(Console.ReadLine());

        Student s = new Student();

        s.ShowStudentDetails(name, rollNo, tamil, english, maths);

        int total = s.CalculateTotal(tamil, english, maths);
        Console.WriteLine("Total Marks: " + total);

        double average = s.CalculateAverage(total);
        Console.WriteLine("Average Marks: " + average);

        s.DisplayGrade(average);
    }
}