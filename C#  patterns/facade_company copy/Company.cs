namespace facade_company;

class Company
{
    public List<Department> Departments { get; } = new();

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
        Console.WriteLine($"Department {department.Name} added to the company");
    }
}
