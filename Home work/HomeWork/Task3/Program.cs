List<DateTime> dates = new List<DateTime>(){new DateTime(2020, 10, 1), new DateTime(2022,8,15),new DateTime(2021,04,28)};
dates.Sort();
System.Console.WriteLine("The sorted dates are: ");
foreach (var it in dates)
{
    System.Console.WriteLine(it);
}