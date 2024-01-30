List<string> removed = new List<string>(){"SaSA", "Asad", "calom"};
var rem1 = removed.Find(e => e=="SaSA");

var rem2 = removed.Remove("SaSA");

foreach (var it in removed)
{
    System.Console.WriteLine(it);
}
System.Console.WriteLine($"Udaleno: {rem1}");