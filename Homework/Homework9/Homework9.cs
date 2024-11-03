namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        //! Q2 4 students created
        Student stud1 = new Student(111, "Alice");
        Student stud2 = new Student(222, "Bob");
        Student stud3 = new Student(333, "Charlie");
        Student stud4 = new Student(444, "David");

        //! Q3 Create gradebook and add students GPA
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        //! Q4 Check if Tom is in the gradebook
        if (gradebook.ContainsKey("Tom"))
        {
            Console.WriteLine("Tom is in the gradebook");
        }
        else
        {
            Student stud5 = new Student(555, "Tom"); // since Tom is being added to gradebook we need to add him to the student list as well
            gradebook.Add("Tom", 3.3);
        }

        //! Q5 Calculate the average GPA of the students in the gradebook
        double avgGPA = 0;
        int count = 0;
        foreach (var student in gradebook)
        {
            avgGPA += student.Value;
            count++;
        }
        avgGPA /= count;
        Console.WriteLine($"The average GPA is: {avgGPA}");

        //! Q6 Print the student info whose GPA is greater than the average GPA
        // wasn't able to find students in the student list (Student.studenName) without public set as access modifier.
        foreach (var student in gradebook)
        {
            if (student.Value > avgGPA)
            {
                foreach (var stud in Student.studentList)
                {
                    if (stud.studentName == student.Key)
                    {
                        stud.PrintInfo();
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}

//! Q1 Student Class
class Student
{
    private int studentID { get; set; }
    public string studentName { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}\nStudent Name: {studentName}\n");
    }
    public static List<Student> studentList = new List<Student>();
    public Student(int studentID, string studentName)
    {
        this.studentID = studentID;
        this.studentName = studentName;
        studentList.Add(this); // Add the student to the list
    }
}
