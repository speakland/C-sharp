using System.Collections;

namespace iterator_company;

class Company : IEnumerable<Employee>
{
    private List<Department> Departments { get;}

    public Company()
    {
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
        Console.WriteLine($"Department {department.Name} added to the company");
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        foreach (var department in Departments)
        {
            foreach (var employee in department)
            {
                yield return employee;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}