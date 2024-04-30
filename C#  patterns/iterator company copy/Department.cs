using System.Collections;

namespace iterator_company;

class Department : IEnumerable<Employee>
{
    public string Name { get;}
    private List<Employee> Employees { get;}

    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
        Console.WriteLine($"Employee {employee.Name} added to department {Name}");
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        return Employees.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

   
}