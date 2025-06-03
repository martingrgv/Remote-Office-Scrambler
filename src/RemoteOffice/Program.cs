using RemoteOffice.Data;

var rnd = new Random();
var employees = Initializer.CreateEmployees();
var shuffledEmployees = employees.OrderBy(x => rnd.Next()).ToList();
var pairsCount = employees.Count / 5;

var possibleDates = Enumerable.Range(0, 5)
     .Select(day =>
            {
                var date = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + day);

                while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    date = date.AddDays(2);
                }

                return date;
            })
    .ToList();

var remoteEmployees = shuffledEmployees
    .Select((employee, index) => new
    {
        Employee = employee,
        Date = possibleDates[index % possibleDates.Count]
    })
    .OrderBy(x => x.Date)
    .ToDictionary(x => x.Employee, x => x.Date);

foreach (var (employee, date) in remoteEmployees)
{
    Console.WriteLine($"{employee.Name}: {date.Day} - {date.DayOfWeek}");
}
