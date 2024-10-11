class Professor
{
   public string? profName;
   public string? classTeach;
   private double salary;
   public void SetSalary(double salary_amount)
   {
      salary = salary_amount;
   }
   public double GetSalary()
   {
      return salary;
   }

}