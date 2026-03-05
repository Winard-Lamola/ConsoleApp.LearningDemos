//See https://aka.ms/new-console-template for more information

//using System.Diagnostics.CodeAnalysis;
using System.Globalization;


Console.WriteLine("************* - DateTime Manipulation - *************");

//Empty Datetime object
DateTime dateTime = new DateTime();

//Cetate a DateTime form date and time
var dateOfBirth = new DateTime(1996, 4, 18);
Console.WriteLine($"Date of Birth: {dateOfBirth}");

var dateTimeOfBirth = new DateTime(1996, 4, 18, 14, 30, 30, DateTimeKind.Local);
Console.WriteLine($"Date and Time of Birth: {dateTimeOfBirth}");

Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {dateTimeOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {dateTimeOfBirth.Ticks}");
Console.WriteLine($"Kind: {dateTimeOfBirth.Kind}");

// Create a DateTime from current timestamp
DateTime currentDateTime = DateTime.Now;
Console.WriteLine($"Current Date and Time: {currentDateTime}");

// Create a DateTime rom string
Console.WriteLine("Enter a date (MM/dd/yyyy): ");
string dobString = Console.ReadLine();
var userdob = DateTime.Parse(dobString);
Console.WriteLine($"Day of Week: {userdob.DayOfWeek}");
Console.WriteLine($"Day of Year: {userdob.DayOfYear}");
Console.WriteLine($"Time of Day: {userdob.TimeOfDay}");
Console.WriteLine($"Tick: {userdob.Ticks}");
Console.WriteLine($"Kind: {userdob.Kind}");


// Change Format DateTime
Console.WriteLine($"Formatted Date: {userdob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {userdob.ToString("MMM, dd, yyyy")}");
Console.WriteLine($"Formatted Date: {userdob.ToString("dd-MMM-yyyy")}");
Console.WriteLine($"Formatted Date: {userdob: ddd, MMMM, yyyy}");
Console.WriteLine($"Formatted Date: {userdob:yyyy, MMMM dd, dddd}");


// Add Additional DateTime
Console.WriteLine("One hour from now is: " + currentDateTime.AddHours(1));
Console.WriteLine("One Day from now is: " + currentDateTime.AddDays(1));
Console.WriteLine("One Day ago now is: " + currentDateTime.AddDays(-1));


Console.WriteLine("************* - DateTime Offset Manipulation - *************");

//Coordinated Universal Time (UTC) DateTime
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Now Date Time: {currentDateTime}");
Console.WriteLine($"UTC Now Date Time: {utcNow}");


// Create DateTimeOffset with TimeZone Information rom the user's computer
// DateTimeOffSet and TimeZone Info
var tymeZone = TimeZoneInfo.Local.GetUtcOffset(utcNow);
Console.WriteLine($"User Time Zone: {tymeZone}");

var dateTimeOffset = new DateTimeOffset(currentDateTime, tymeZone);
Console.WriteLine($"User Time Zone With UTC Offset: {dateTimeOffset}");
Console.WriteLine($"Local Time Of Action: {dateTimeOffset.UtcDateTime}");

var indiaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
var indiaDateTime = TimeZoneInfo.ConvertTime(dateTimeOffset.UtcDateTime, indiaTimeZone);
Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

Console.WriteLine("********* - Date only and Time Only Manipulation - ******************");

//Date Only
//var dateOnly = DateOnly.FromDateTime(DateTime.Now);
var dateOnly = new DateOnly(1996, 04, 18);
var nextDay = dateOnly.AddDays(1);
var previousDay = dateOnly.AddDays(-1);
var decadeLater = dateOnly.AddYears(10);
var lastMonth = dateOnly.AddMonths(-1);

Console.WriteLine($"Date Only: {dateOnly}");
Console.WriteLine($"Next Day: {nextDay}");
Console.WriteLine($"Previous Day: {previousDay}");
Console.WriteLine($"Decade Later: {decadeLater}");
Console.WriteLine($"Last Month: {lastMonth}");

var dateOnlyFromDateTime = DateOnly.FromDateTime(currentDateTime);
Console.WriteLine($"Date Only from DateTime: {dateOnlyFromDateTime}");

Console.WriteLine("What is your DOB (dd MMM yyyy): ");
string dobDateOnly = Console.ReadLine();

var userDobOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy",
    CultureInfo.InvariantCulture);
Console.WriteLine($"User DOB: {userDobOnly}");

//Time Only
var timeOnlyNow = TimeOnly.FromDateTime( currentDateTime );
Console.WriteLine($"Time Only Now: {timeOnlyNow}");
Console.WriteLine($"Time Only Now: {timeOnlyNow:hh:mm tt}");

//Date Comparison
var date1 = new DateTime(2018, 06, 01);
var date2 = new DateTime(1998, 06, 15);

Console.WriteLine($" Is '{nameof(date1)} equal?' {date1 == date2}");
Console.WriteLine($" Is '{nameof(date1)} equal?' {date1.Equals(date2)}");
Console.WriteLine($" Is {date1} after? {date2 > date1}");
Console.WriteLine($" Is {date2} before? {date2 < date1}");