class Student
{
   public static List<Student> student_list = new List<Student>();
   public int studentID { get; set; }
   public string studentName { get; set; }
   public void PrintInfo()
   {
      Console.WriteLine($"Student Info For:\n- ID: {studentID}\n- Name: {studentName}\n");
   }

   public Student(int id, string name)
   {
      studentID = id;
      studentName = name;
      student_list.Add(this);
   }
}