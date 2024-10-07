// Important file name must === class name
class Student
{
    public string? studentName;
    public int age;
    public string? address;

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student: {studentName} \n Age: {age} \n Address: {address}");
    }

    public void ChangeAddress(string new_address)
    {
        address = new_address;
    }

}