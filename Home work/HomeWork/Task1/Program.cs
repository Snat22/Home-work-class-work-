List<int> numbers = new List<int>(){1,2,3,4,5};
int sum = 0;
foreach (var it in numbers)
{
    sum += it;
}
System.Console.WriteLine("The sum of all the ekements in the list is: " +sum);