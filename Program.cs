namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID =  1, Name = "Bilal", Experience = 3, Salary = 100000 });
            emplist.Add(new Employee() { ID =  2, Name = "Ali", Experience = 5, Salary = 120000 });
            emplist.Add(new Employee() { ID =  3, Name = "Ahamd", Experience = 4, Salary = 200000 });
            emplist.Add(new Employee() { ID =  4, Name = "Ismaeel", Experience = 6, Salary = 180000 });

            Employee.PromoteEmployee(emplist);
        }
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if(employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }
    }
}
