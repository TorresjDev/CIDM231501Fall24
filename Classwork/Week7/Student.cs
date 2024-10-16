// Important file name must === class name
class Student
{
    public string? studentName;
    public int age;
    public string? address;

    private string grade; //example of encapsulation - private field with public methods to access it

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student: {studentName} \n Age: {age} \n Address: {address}");
    }

    public void ChangeAddress(string new_address)
    {
        address = new_address;
    }

    public void PrintGrade(string grade)
    {
        Console.WriteLine($"Student grade is {grade}")
    }
|
    //* Encapsulation is the concept of restricting access to certain parts of an object. In this case, the grade field is private, so it can only be accessed through the public methods PrintGrade. This is a good practice because it allows us to control how the grade field is accessed and modified. For example, we could add validation logic to the SetGrade method to ensure that the grade is within a certain range. This helps to prevent bugs and make the code more robust.
}