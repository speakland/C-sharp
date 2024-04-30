namespace facade_company;


class Department(string name)
{
    public string Name { get; } = name;
    public List<Employee> Employees { get; } = new();

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
        Console.WriteLine($"Employee {employee.Name} added to department {Name}");
    }
}