
using iterator_company;

class Program
{
    static void Main(string[] args)
    {
        
        Company company = new Company(); // Создание компании, отделов и сотрудников

        Department itDepartment = new Department("IT");
        Department salesDepartment = new Department("Sales");
        
        company.AddDepartment(itDepartment);
        company.AddDepartment(salesDepartment);
        
        itDepartment.AddEmployee(new Employee("John", "Developer"));
        itDepartment.AddEmployee(new Employee("Mark", "Tester"));
        
        salesDepartment.AddEmployee(new Employee("Bob", "Sales Manager"));
        salesDepartment.AddEmployee(new Employee("Crob", "Marketing"));
        
        Console.WriteLine("Company employees:");      //перебор всех сотрудников компании
        foreach (var employee in company)
        {
            Console.WriteLine($"Name: {employee.Name}, Position: {employee.Position}");
        }
        
        Console.WriteLine("\nEmployees in IT department:");  //перебора сотрудников в определенном отделе
        foreach (var employee in itDepartment)
        {
            Console.WriteLine($"Name: {employee.Name}, Position: {employee.Position}");
        }
    }
}
