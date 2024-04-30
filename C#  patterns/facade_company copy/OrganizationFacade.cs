namespace facade_company;

class OrganizationFacade
{
    private Company company = new();

    public void AddEmployeeToDepartment(string employeeName, string position, string departmentName)
    {
        Department department = GetDepartment(departmentName);
        {
            Employee employee = new Employee(employeeName, position);
            department.AddEmployee(employee);
        }
    }

    private Department GetDepartment(string departmentName)
    {
        foreach (var department in company.Departments)
        {
            if (department.Name == departmentName)
            {
                return department;
            }
        }
        return null;
    }

    public void AddDepartment(string departmentName)
    {
        Department department = new Department(departmentName);
        company.AddDepartment(department);
    }
}