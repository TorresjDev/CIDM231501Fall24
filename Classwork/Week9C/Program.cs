namespace Week9C;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Class Objects with Arrays");


        // * Exercise Student
        Console.WriteLine("Exercise Student");

        Student stud1 = new Student(studentID: 111, studentName: "Alice", studentGPA: 3.6);
        Student stud2 = new Student(studentID: 222, studentName: "Bob", studentGPA: 3.5);
        Student stud3 = new Student(studentID: 333, studentName: "Cathy", studentGPA: 3.1);

        Student[] student_array = { stud1, stud2, stud3 };

        int count = 0;
        foreach (Student stud in student_array)
        {
            count++;
            stud.PrintStudInfo(count);
        }

        // * Exercise Food
        Console.WriteLine("\nExercise Food");
        Food food1 = new Food("Juice", 3.49, "Drink");
        Food food2 = new Food("Orange", 0.99, "Fruit");
        Food food3 = new Food("Chicken", 8.99, "Meat");
        Food food4 = new Food("Broccoli", 2.49, "Vegetable");
        Food food5 = new Food("Banana", 0.59, "Fruit");
        Food food6 = new Food("Beef", 14.99, "Meat");
        Food food7 = new Food("Carrot", 1.29, "Vegetable");
        Food food8 = new Food("Soda", 2.99, "Drink");

        Food[] shopping_list = { food1, food2, food3, food4, food5, food6, food7, food8 };

        TotalPrice(shopping_list);
        TotalFruitPrice(shopping_list);
        AveragePrice(shopping_list);
    }

    public static void TotalPrice(Food[] shopping_list)
    {
        double totalPrice = 0;
        foreach (Food food in shopping_list)
        {
            totalPrice += food.foodPrice;
        }
        Console.WriteLine($"TotalPrice: {totalPrice}");
    }

    public static void TotalFruitPrice(Food[] shopping_list)
    {
        double totalFruitPrice = 0;
        foreach (Food food in shopping_list)
        {
            if (food.foodType == "Fruit")
            {
                totalFruitPrice += food.foodPrice;
            }
        }
        Console.WriteLine($"Total Fruit Price: {totalFruitPrice}");
    }

    public static void AveragePrice(Food[] shopping_list)
    {
        double totalPrice = 0;
        double count = 0;
        double averagePrice = 0;
        foreach (Food food in shopping_list)
        {
            count++;
            totalPrice += food.foodPrice;
        }
        averagePrice = totalPrice / count;
        Console.WriteLine($"Average Price: {averagePrice}");
    }
}

// * For Student Exercise 
class Student
{
    public int studentID { get; set; } = 0;
    public string studentName { get; set; } = string.Empty;
    public double studentGPA { get; set; } = 0;
    public void PrintStudInfo(int index)
    {
        Console.WriteLine($"Student {index}\n- ID: {studentID}\n- Name: {studentName}\n- GPA: {studentGPA}");
    }
    public Student(int studentID, string studentName, double studentGPA)
    {
        this.studentID = studentID;
        this.studentName = studentName;
        this.studentGPA = studentGPA;
    }
}

// * For Food Exercise 
class Food
{
    public string foodName { get; set; } = string.Empty;
    public double foodPrice { get; set; } = 0;
    public string foodType { get; set; } = string.Empty;
    public Food(string foodName, double foodPrice, string foodType)
    {
        this.foodName = foodName;
        this.foodPrice = foodPrice;
        this.foodType = foodType;
    }
}