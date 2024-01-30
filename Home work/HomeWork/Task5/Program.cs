List<int> numbers = new List<int>(){1, 2, 3, 4, 5};
System.Console.WriteLine("The filtered numbers are: ");
List<int>evenNumvbers = numbers.FindAll(n => n%2==0);
foreach (var num in  evenNumvbers)
{
    System.Console.WriteLine(num);    
}
