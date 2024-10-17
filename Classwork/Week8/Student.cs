class Student
{
   public int id = 0;
   public int age = 0;
   public string name = string.Empty;
   public void PrintInfo()
   {
      Console.WriteLine($"Student ID: {id} Student Name: {name} Student Age: {age}");
   }

   // * Constructor
   // - special method that is called when an object is created
   // - used to initialize the object
   public Student(int input_id, int input_age, string input_name)
   {
      id = input_id;
      age = input_age;
      name = input_name;
   }

   public Student()
   {
      Console.WriteLine("Empty Student Object Created");
   }
}

// * Class Constructors
// - a special method of a class that is called automatically when a new instance of the class is created
// - constructors have the same name as the class, always public, and do not have a return type
// - constructors are optional, if not defined, the compiler will provide a default constructor