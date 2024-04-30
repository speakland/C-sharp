using facade_company;

class Program
{
    static void Main()
    {
        OrganizationFacade facade = new OrganizationFacade();
        
        facade.AddDepartment("IT");
        facade.AddEmployeeToDepartment("John", "Developer", "IT");
        
        Meeting meeting = new Meeting("Weekly Team Meeting", DateTime.Now.AddDays(7), "Conference Room 1");
        meeting.Schedule();
    }
}
