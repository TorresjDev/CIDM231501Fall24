namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Q1: C# Class Implementation
        Professor profAlice = new Professor();
        CreateProfessor(profAlice, "Alice", "Java", 9000);
        Professor profBob = new Professor();
        CreateProfessor(profBob, "Bob", "C#", 8000);
        Student studLisa = new Student();
        CreateStudent(studLisa, "Lisa", "Java", 90);
        Student studTom = new Student();
        CreateStudent(studTom, "Tom", "C#", 80);

        // Q2: Printing and Calculating Results
        double salaryDiff = SalaryDifference(profAlice.GetSalary(), profBob.GetSalary());
        Console.WriteLine($"The salary difference between Alice and Bob is: ${salaryDiff}");
        double totalGrade = CalculateGrades(studLisa.GetGrade(), studTom.GetGrade());
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");

    }

    // Q1: C# Class Implementation - methods
    static void CreateProfessor(Professor pObj, string pName, string pTClass, double pSalary)
    {
        pObj.profName = pName;
        pObj.classTeach = pTClass;
        pObj.SetSalary(pSalary);
        Console.WriteLine($"Professor {pObj.profName} teaches {pObj.classTeach}, and the salary is: ${pObj.GetSalary()}.");
    }
    static void CreateStudent(Student sObj, string sName, string sClass, double sGrade)
    {
        sObj.studentName = sName;
        sObj.classEnroll = sClass;
        sObj.SetGrade(sGrade);
        Console.WriteLine($"Student {sObj.studentName} enrolled in {sObj.classEnroll}, and the grade is: {sObj.GetGrade()}.");
    }

    // Q2: Printing and Calculating Results
    static double CalculateGrades(double grade1, double grade2)
    {
        double totalGrade = grade1 + grade2;
        return totalGrade;
    }
    static double SalaryDifference(double salary1, double salary2)
    {
        double salaryDiff = 0;
        if (salary1 > salary2)
        {
            salaryDiff = salary1 - salary2;
        }
        else
        {
            salaryDiff = salary2 - salary1;
        }
        return salaryDiff;
    }
}

// Q1: C# Class Implementation - Classes
class Professor
{
    public string? profName;
    public string? classTeach;
    private double salary; //example of encapsulation - private field with public methods to access it 
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public double GetSalary()
    {
        return salary;
    }

}

class Student
{
    public string? studentName;
    public string? classEnroll;
    private double studentGrade;
    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    public double GetGrade()
    {
        return studentGrade;
    }
}