// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");


//String Methods
string name = "John";
string greeting = "Hello";
string message = greeting + " " + name;
Console.WriteLine(message);

string capsMessage = message.ToUpper();
Console.WriteLine(capsMessage);

string lowerMessage = message.ToLower();
Console.WriteLine(lowerMessage);

string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

string fullName2 = string.Concat(firstName, " ", lastName);
Console.WriteLine(fullName2);

string fullName3 = $"{firstName} {lastName}";
Console.WriteLine(fullName3);

string fullName4 = string.Format("{0} {1}", firstName, lastName);
Console.WriteLine(fullName4);

string fullName5 = string.Join(" ", firstName, lastName);
Console.WriteLine(fullName5);

string fullName6 = $"{firstName} {lastName}".Replace("John", "Jane");
Console.WriteLine(fullName6);

string fullName7 = $"{firstName} {lastName}".Substring(5);
Console.WriteLine(fullName7);

string fullName8 = $"{firstName} {lastName}".Substring(5, 2);
Console.WriteLine(fullName8);

string fullName9 = $"{firstName} {lastName}".Remove(5);
Console.WriteLine(fullName9);

string fullName10 = $"{firstName} {lastName}".Remove(5, 2);
Console.WriteLine(fullName10);

string fullName11 = $"{firstName} {lastName}".Insert(5, "X");
Console.WriteLine(fullName11);

string fullName12 = $"{firstName} {lastName}".PadLeft(15);
Console.WriteLine(fullName12);

string fullName13 = $"{firstName} {lastName}".PadRight(15);
Console.WriteLine(fullName13);

string fullName14 = $"{firstName} {lastName}".Trim();
Console.WriteLine(fullName14);

string fullName15 = $"{firstName} {lastName}".TrimStart();
Console.WriteLine(fullName15);

string fullName16 = $"{firstName} {lastName}".TrimEnd();
Console.WriteLine(fullName16);

string fullName17 = $"{firstName} {lastName}".Trim('J');
Console.WriteLine(fullName17);

string fullName18 = $"{firstName} {lastName}".TrimStart('J');
Console.WriteLine(fullName18);

string fullName19 = $"{firstName} {lastName}".TrimEnd('e');
Console.WriteLine(fullName19);

string fullName20 = $"{firstName} {lastName}".Trim('J', 'e');
Console.WriteLine(fullName20);


//DateTime Methods

DateTime now = DateTime.Now;
Console.WriteLine(now);

DateTime today = DateTime.Today;
Console.WriteLine(today);

DateTime tomorrow = today.AddDays(1);
Console.WriteLine(tomorrow);

DateTime yesterday = today.AddDays(-1);
Console.WriteLine(yesterday);

DateTime nextWeek = today.AddDays(7);
Console.WriteLine(nextWeek);


//TimeSpan Methods
//TimeSpan, a struct, represents a time interval. It is used to measure time durations.
DateTime start = DateTime.Now;
DateTime end = DateTime.Now.AddSeconds(30);
TimeSpan duration = end - start;
Console.WriteLine(duration);

TimeSpan halfHour = new TimeSpan(0, 30, 0);
Console.WriteLine(halfHour);

TimeSpan halfHour2 = TimeSpan.FromMinutes(30);
Console.WriteLine(halfHour2);
