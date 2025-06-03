using RemoteOffice.Models;

namespace RemoteOffice.Data;

public class Initializer
{
    public static IList<Employee> CreateEmployees()
    {
        var employees = new List<Employee>
        {
            new() { Name = "Employee1" },
            new() { Name = "Employee2" },
            new() { Name = "Employee3" },
            new() { Name = "Employee4" },
            new() { Name = "Employee5" },
            new() { Name = "Employee6" },
            new() { Name = "Employee7" },
            new() { Name = "Employee8" },
            new() { Name = "Employee9" },
        };

        return employees;
    }
}
