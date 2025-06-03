namespace RemoteOffice.Models;

public class RemoteEmployee
{
    public RemoteEmployee(Employee employee, DateOnly remoteDate)
    {
        Employee = employee;
        RemoteDate = remoteDate;
    }

    public Employee Employee { get; } = null!;
    public DateOnly RemoteDate { get; }
}
