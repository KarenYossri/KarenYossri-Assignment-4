using System;
using System.Text;
using BenchmarkDotNet.Running;

string[] sessionNames =
{
"C# Basics",
"Arrays",
"Functions",
"Date and Time",
"Exception Handling"
};

DateTime[] sessionDates =
{
new DateTime(2026, 9, 10, 18, 0, 0),
new DateTime(2026, 9, 13, 18, 0, 0),
new DateTime(2026, 9, 17, 18, 0, 0),
new DateTime(2026, 9, 20, 18, 0, 0),
new DateTime(2026, 9, 24, 18, 0, 0)
};

int[] sessionDurations =
{
180,
240,
180,
240,
180
};

Console.WriteLine("=== Academy Schedule Analyzer ===");

DisplaySessions(sessionNames, sessionDates, sessionDurations);

void DisplaySessions(string[] names, DateTime[] dates, int[] durations)
{
for (int i = 0; i < names.Length; i++)
{
Console.WriteLine($"Session: {names[i]}");
Console.WriteLine($"Date: {dates[i]:dd MMMM yyyy}");
Console.WriteLine($"Start Time: {dates[i]:hh:mm tt}");
Console.WriteLine($"Duration: {durations[i]} minutes");
Console.WriteLine();
}
}
Console.WriteLine("=== PART 3: Search for a Session ===");

Console.Write("Enter session name: ");
string searchName = Console.ReadLine() ?? "";

SearchSession(searchName, sessionNames, sessionDates, sessionDurations);

int SearchSession(string name, string[] names, DateTime[] dates, int[] durations)
{
int index = Array.IndexOf(names, name);

if (index != -1)
{
    Console.WriteLine($"Name: {names[index]}");
    Console.WriteLine($"Date: {dates[index]:dd MMMM yyyy}");
    Console.WriteLine($"Start Time: {dates[index]:hh:mm tt}");
    Console.WriteLine($"Duration: {durations[index]} minutes");
}
else
{
    Console.WriteLine("Session not found.");
}
return index;
}
Console.WriteLine("=== PART 4: Array Methods Practice ===");

// 4.1 Sort Session Names
string[] sortedNames = new string[sessionNames.Length];
Array.Copy(sessionNames, sortedNames, sessionNames.Length);
Array.Sort(sortedNames);

Console.WriteLine("Sorted session names:");
foreach (string session in sortedNames)
{
Console.WriteLine(session);
}

// 4.2 Reverse Session Names
string[] reversedNames = new string[sessionNames.Length];
Array.Copy(sessionNames, reversedNames, sessionNames.Length);
Array.Reverse(reversedNames);

Console.WriteLine("Reversed session names:");
foreach (string session in reversedNames)
{
Console.WriteLine(session);
}

// 4.3 Find Session Index
Console.Write("Enter session name to find its index: ");
string indexName = Console.ReadLine() ?? "";

int sessionIndex = Array.IndexOf(sessionNames, indexName);

Console.WriteLine($"Index: {sessionIndex}");

// 4.4 Check if a Session Exists
Console.Write("Enter session name to check: ");
string existsName = Console.ReadLine() ?? "";

bool exists = Array.Exists(sessionNames, name => name == existsName);

if (exists)
{
Console.WriteLine("Session exists.");
}
else
{
Console.WriteLine("Session does not exist.");
}

// 4.5 Find a Session
string foundSession = Array.Find(sessionNames, name => name.Contains("Date")) ?? "No session found";

Console.WriteLine($"Found session: {foundSession}");

// 4.6 Find Session Index Using a Condition
int foundIndex = Array.FindIndex(sessionNames, name => name.Contains("Exception"));

Console.WriteLine($"Found index: {foundIndex}");

// 4.7 Copy an Array
string[] copiedNames = new string[sessionNames.Length];
Array.Copy(sessionNames, copiedNames, sessionNames.Length);

copiedNames[0] = "Changed Session";

Console.WriteLine("Original array:");
foreach (string session in sessionNames)
{
Console.WriteLine(session);
}

Console.WriteLine("Copied array:");
foreach (string session in copiedNames)
{
Console.WriteLine(session);
}
Console.WriteLine("=== PART 5: Duration Analysis ===");
int totalDuration = GetTotalDuration(sessionDurations);
double averageDuration = GetAverageDuration(sessionDurations);
int shortestDuration = GetShortestDuration(sessionDurations);
int longestDuration = GetLongestDuration(sessionDurations);
Console.WriteLine($"Total Duration: {totalDuration} minutes");
Console.WriteLine($"Average Duration: {averageDuration} minutes");
Console.WriteLine($"Shortest Duration: {shortestDuration} minutes");
Console.WriteLine($"Longest Duration: {longestDuration} minutes");
int[] sortedDurations = new int[sessionDurations.Length];
Array.Copy(sessionDurations, sortedDurations, sessionDurations.Length);
Array.Sort(sortedDurations);
Console.WriteLine("Sorted durations:");
foreach (int duration in sortedDurations)
{
Console.WriteLine($"{duration} minutes");
}
int GetTotalDuration(int[] durations)
{
int total = 0;

foreach (int duration in durations)

{

total += duration;

}

return total;
}


double GetAverageDuration(int[] durations)

{

int total = GetTotalDuration(durations);

return (double)total / durations.Length;

}

int GetShortestDuration(int[] durations)

{

int shortest = durations[0];

foreach (int duration in durations)

{

if (duration < shortest)

{

shortest = duration;

}

}

return shortest;

}

int GetLongestDuration(int[] durations)

{

int longest = durations[0];

foreach (int duration in durations)

{

if (duration > longest)

{

longest = duration;

}

}

return longest;

}
DisplaySessions(sessionNames, sessionDates, sessionDurations);

void DisplaySessionDetails(int index, string[] names, DateTime[] dates, int[] durations)

{if (index == -1)

{

Console.WriteLine("Session not found.");

return;

}

DateTime endTime = GetSessionEndTime(dates[index], durations[index]);

Console.WriteLine($"Session: {names[index]}");
Console.WriteLine($"Date: {dates[index]:dd MMMM yyyy}");

Console.WriteLine($"Day: {dates[index].DayOfWeek}");

Console.WriteLine($"Year: {dates[index].Year}");

Console.WriteLine($"Month: {dates[index].Month}");

Console.WriteLine($"Day Number: {dates[index].Day}");

Console.WriteLine($"Start: {dates[index]:yyyy-MM-dd HH:mm}");

Console.WriteLine($"Duration: {durations[index]} minutes");

Console.WriteLine($"End: {endTime:yyyy-MM-dd HH:mm}");

}

DateTime GetSessionEndTime(DateTime startTime, int duration)

{

return startTime.AddMinutes(duration);

}

DateTime ReadSessionDate(string input)

{

if (DateTime.TryParseExact(input, "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime result))

{

return result;

}

return DateTime.MinValue;

}
int number = 10;

Console.WriteLine($"Before ref: {number}");

ChangeValue(ref number);

Console.WriteLine($"After ref: {number}");
void ChangeValue(ref int number)

{

}

int foundDuration;

GetSessionInfo("Arrays", sessionNames, sessionDurations, out foundIndex, out foundDuration);

Console.WriteLine($"Found Index: {foundIndex}");

Console.WriteLine($"Found Duration: {foundDuration} minutes");
void GetSessionInfo(string searchName, string[] names, int[] durations, out int index, out int duration)

{
index = Array.IndexOf(names, searchName);

duration = index >= 0 ? durations[index] : 0;
}
int[] testArray = { 10, 20, 30 };

Console.WriteLine("Before change:");

foreach (int value in testArray)
{
Console.WriteLine(value);
}

ChangeArrayValue(testArray);

Console.WriteLine("After change:");

foreach (int value in testArray)
{
Console.WriteLine(value);
}
void ChangeArrayValue(int[] values)
{
values[0] = 100;
}
CalculateTotalDuration(120, 180);

CalculateTotalDuration(120, 180, 240);

CalculateTotalDuration(60, 90, 120, 180, 240);
int CalculateTotalDuration(params int[] durations)

{
int total = 0;

foreach (int duration in durations)
{
total += duration;
}

Console.WriteLine($"Total Duration: {total} minutes");

return total;

}
Console.Write("Enter first session: ");
string firstSession = Console.ReadLine();

Console.Write("Enter second session: ");
string secondSession = Console.ReadLine();

int firstIndex = Array.IndexOf(sessionNames, firstSession);
int secondIndex = Array.IndexOf(sessionNames, secondSession);

TimeSpan difference = sessionDates[secondIndex] - sessionDates[firstIndex];

Console.WriteLine($"Difference: {difference.Days} days");
Console.WriteLine($"Difference: {difference.TotalHours} hours");


Console.WriteLine("=== PART 11: Past and Upcoming Sessions ===");

for (int i = 0; i < sessionNames.Length; i++)
{
    if (sessionDates[i] < DateTime.Now)
    {
        Console.WriteLine($"{sessionNames[i]} - Past");
    }
    else
    {
        Console.WriteLine($"{sessionNames[i]} - Upcoming");
    }
}
Console.WriteLine("=== PART 12: Find the Next Session ===");

int nextIndex = -1;
DateTime nearestDate = DateTime.MaxValue;

for (int i = 0; i < sessionDates.Length; i++)
{
    if (sessionDates[i] > DateTime.Now && sessionDates[i] < nearestDate)
    {
        nearestDate = sessionDates[i];
        nextIndex = i;
    }
}

if (nextIndex != -1)
{
    TimeSpan remaining = sessionDates[nextIndex] - DateTime.Now;

    Console.WriteLine($"Next Session: {sessionNames[nextIndex]}");
    Console.WriteLine($"Date: {sessionDates[nextIndex]:dd MMMM yyyy}");
    Console.WriteLine($"Start Time: {sessionDates[nextIndex]:hh:mm tt}");
    Console.WriteLine($"Time Remaining: {remaining.Days} days");
    Console.WriteLine($"Time Remaining: {remaining.Hours} hours");
}
else
{
    Console.WriteLine("No upcoming sessions.");
}
Console.WriteLine("=== PART 13: Date Formatting ===");

int formatIndex = Array.IndexOf(sessionNames, "Arrays");

Console.WriteLine($"{sessionDates[formatIndex]:yyyy-MM-dd}");
Console.WriteLine($"{sessionDates[formatIndex]:dd/MM/yyyy}");
Console.WriteLine($"{sessionDates[formatIndex]:dd MMMM yyyy}");
Console.WriteLine($"{sessionDates[formatIndex]:dddd, dd MMMM yyyy}");
Console.WriteLine($"{sessionDates[formatIndex]:hh:mm tt}");

Console.WriteLine("=== PART 14: Read and Validate a Date ===");

Console.Write("Enter a date (yyyy-MM-dd HH:mm): ");
string input = Console.ReadLine();

DateTime customDate = ReadSessionDate(input);

Console.WriteLine("=== PART 15: Exception Handling: Menu Input ===");

int menuOption = 0;
bool validOption = false;

while (!validOption)
{
    Console.Write("Choose an option: ");

    try
    {
        menuOption = int.Parse(Console.ReadLine());
        validOption = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid menu option. Enter a number.");
    }
}

Console.WriteLine($"Selected option: {menuOption}");

Console.WriteLine("=== PART 16: Exception Handling: Invalid Array Index ===");

Console.Write("Enter session index: ");

try
{
    int index = int.Parse(Console.ReadLine());

    Console.WriteLine($"Session: {sessionNames[index]}");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("The selected session index is out of range.");
}

Console.WriteLine("=== PART 17: Throw an Exception ===");

Console.Write("Enter duration: ");
int durationInput = int.Parse(Console.ReadLine());

try
{
    ValidateDuration(durationInput);
    Console.WriteLine("Duration accepted.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

void ValidateDuration(int duration)
{
    if (duration <= 0)
    {
        throw new ArgumentException("Duration must be greater than zero.");
    }
}
Console.WriteLine("=== PART 18: finally ===");

Console.Write("Enter duration: ");

try
{
    int durationInput18 = int.Parse(Console.ReadLine());

    ValidateDuration(durationInput18);

    Console.WriteLine("Duration accepted.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException)
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Input operation finished.");
}
Console.WriteLine("=== PART 19: Build Report Using string ===");

string report =
    "Academy Schedule Report\n" +
    "=======================\n";

for (int i = 0; i < sessionNames.Length; i++)
{
    report += $"{sessionNames[i]} | {sessionDates[i]:yyyy-MM-dd HH:mm} | {sessionDurations[i]} minutes\n";
}

Console.WriteLine(report);

Console.WriteLine("=== PART 20: Build Report Using StringBuilder ===");

string report2 = BuildReportWithStringBuilder(
    sessionNames,
    sessionDates,
    sessionDurations
);

Console.WriteLine(report2);

string BuildReportWithStringBuilder(
    string[] names,
    DateTime[] dates,
    int[] durations)
{
    StringBuilder sb = new StringBuilder();

    sb.AppendLine("Academy Schedule Report");
    sb.AppendLine("=======================");

    for (int i = 0; i < names.Length; i++)
    {
        sb.AppendLine(
            $"{names[i]} | {dates[i]:yyyy-MM-dd HH:mm} | {durations[i]} minutes"
        );
    }

    return sb.ToString();
}

BenchmarkRunner.Run<Benchmark>();
