namespace Week7;

class Program
{
    static void Main(string[] args)
    {
        Professor professorObj = new Professor();
        professorObj.name = "Alice";
        professorObj.age = 30;
        professorObj.PrintInfo();

        Professor pObj = new Professor();
        pObj.name = "Bill";
        pObj.age = 25;
        pObj.PrintInfo();

        Professor newProObj = new Professor();
        CreateProfessor(newProObj, "Jesus", 26);

        Building B1 = new Building();
        B1.name = "Classroom Center";
        B1.address = "Canyon";
        B1.num_rooms = 100;
        B1.PrintBuildingInfo();
        B1.UpdateName("Study Center");
        Console.WriteLine($"Building name has been updated: {B1.name}");

        Building B2 = new Building();
        CreateBuilding(B2, "Classroom Center", "Old Main", 9);

        Student std1 = new Student();
        std1.studentName = "Jesus";
        std1.age = 33;
        std1.address = "Amarillo";
        std1.PrintStudentInfo();
        std1.ChangeAddress("Canyon");
        Console.WriteLine($"Student Address has been updated to: {std1.address}");

        Student newStud = new Student();
        CreateStudent(newStud, "Bill", 32, "Canyon");
    }

    public static void CreateProfessor(Professor pObj, string pName, int pAge)
    {
        pObj.name = pName;
        pObj.age = pAge;
        pObj.PrintInfo();

    }

    public static void CreateBuilding(Building bObj, string bName, string bAddress, int bRooms = 0)
    {
        bObj.name = bName;
        bObj.address = bAddress;
        bObj.num_rooms = bRooms;
        bObj.PrintBuildingInfo();
    }

    public static void CreateStudent(Student sObj, string sName, int sAge, string sAddress)
    {
        sObj.studentName = sName;
        sObj.age = sAge;
        sObj.address = sAddress;
        sObj.PrintStudentInfo();
    }
}

