// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
// DateTime now = DateTime.Now;
// Console.WriteLine(now);

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
// DateTime today = DateTime.Today;
// Console.WriteLine(today);

// TODO: DateOnly and TimeOnly represent just dates and times
// DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
// TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now);
// System.Console.WriteLine(dt);
// System.Console.WriteLine(tm);

// // TODO: Dates have properties that can be inspected
// Console.WriteLine(today.DayOfWeek);
// Console.WriteLine(today.DayOfYear);

// TODO: Dates also have methods to change their values
// now.AddDays(5);
// now.AddHours(5);
// Console.WriteLine(now);

// TODO: The TimeSpan class represents a duration of time
// DateTime AprilFools = new DateTime(now.Year, 4, 1);
// DateTime NewYears = new DateTime(now.Year, 1, 1);
// TimeSpan interval = AprilFools - NewYears;
// Console.WriteLine(interval);

// TODO: Dates can be compared using regular operators
// Console.WriteLine($"{AprilFools > NewYears}");
// Console.WriteLine($"{AprilFools < NewYears}");

string response;
DateTime parsedDate;

Console.WriteLine("Which date? (or 'exit')");
response = Console.ReadLine();

while (response != "exit") {
  if(DateTime.TryParse(response, out parsedDate)) {
    DateTime now = DateTime.Now;
    TimeSpan interval = now - parsedDate;
    Console.WriteLine($"That date went by {(now - parsedDate).Days} days ago");
    Console.WriteLine("Which date? (or 'exit')");
    response = Console.ReadLine();
    } else {
        Console.WriteLine("Could not parse date");
        Console.WriteLine("Which date? (or 'exit')");
    response = Console.ReadLine();
        // somehow return to asking what date
    }
}