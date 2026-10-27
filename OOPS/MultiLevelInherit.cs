class Methodsystem
{
    public int students;
    public string[] name;
    public int[] roll, eng, mat, phy, chem, bio;
    public int[] total;
    public double[] avg;
    public char[] grade;
    public void GetDetails()
    {
        Console.WriteLine("Enter number of students:");
        students = Convert.ToInt32(Console.ReadLine());
        name = new string[students];
        roll = new int[students];
        eng = new int[students];
        mat = new int[students];
        phy = new int[students];
        chem = new int[students];
        bio = new int[students];
        total = new int[students];
        avg = new double[students];
        grade = new char[students];
        for (int i = 0; i < students; i++)
        {
            Console.WriteLine("Enter student name:");
            name[i] = Console.ReadLine();

            Console.WriteLine("Enter roll number:");
            roll[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter English marks:");
            eng[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Maths marks:");
            mat[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Physics marks:");
            phy[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Chemistry marks:");
            chem[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Biology marks:");
            bio[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

class B : Methodsystem
{
    
    public void CalculateTotal()
    {
        for (int i = 0; i < students; i++)
        {
            total[i] = eng[i] + mat[i] + phy[i]
                     + chem[i] + bio[i];
        }
    }
}
class C : B
{
    public void CalculateAverage()
    {
        for (int i = 0; i < students; i++)
        {
            avg[i] = total[i] / 5.0;

            if (avg[i] >= 90)
                grade[i] = 'S';
            else if (avg[i] >= 80)
                grade[i] = 'A';
            else if (avg[i] >= 70)
                grade[i] = 'B';
            else if (avg[i] >= 60)
                grade[i] = 'C';
            else if (avg[i] >= 40)
                grade[i] = 'D';
            else
                grade[i] = 'U';
        }
    }
}
class D : C
{
    public void DisplayDetails()
    {
        for (int i = 0; i < students; i++)
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Name: " + name[i]);
            Console.WriteLine("Roll Number: " + roll[i]);
            Console.WriteLine("English: " + eng[i]);
            Console.WriteLine("Maths: " + mat[i]);
            Console.WriteLine("Physics: " + phy[i]);
            Console.WriteLine("Chemistry: " + chem[i]);
            Console.WriteLine("Biology: " + bio[i]);
            Console.WriteLine("Total: " + total[i]);
            Console.WriteLine("Average: " + avg[i]);
            Console.WriteLine("Grade: " + grade[i]);
        }
    }
}
class StudentSystem2
{
    static void Main()
    {
        D obj = new D();
        obj.GetDetails();
        obj.CalculateTotal();
        obj.CalculateAverage();
        obj.DisplayDetails();
    }
}