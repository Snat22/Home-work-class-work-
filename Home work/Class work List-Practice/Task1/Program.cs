var spisok = new List<string>(){"applee","banana","orange"};
//Vivod na Ekran kolichestvo elementov:
   int cnt = 1;
foreach (var s in spisok)
{
     System.Console.Write($"{cnt++}:");

    System.Console.Write($"{s}.  ");
}
System.Console.WriteLine();
System.Console.WriteLine($"Size: {spisok.Count}");

spisok.Remove("banana");

System.Console.WriteLine("<--------------------->");

int a = 1;
foreach (var s in spisok)
{
     System.Console.Write($"{a++}:");

    System.Console.Write($"{s}.  ");
}
System.Console.WriteLine();
System.Console.WriteLine($"Size: {spisok.Count}");

//Proverka na nalichiye Apple
var containsApple = spisok.Contains("apple");
System.Console.WriteLine();
System.Console.WriteLine("Has is spisok apple if has true: else false:");
System.Console.WriteLine(containsApple);

//Ochistit spisok
System.Console.WriteLine("<-------------------------->");
spisok.Clear();

//Sozdat noviy spisok
System.Console.WriteLine("List2:");
System.Console.WriteLine();
var spisok1 = new List<string>(){"applee","banana","orange","Sunatullo"};
spisok1.Insert(0,"grappe");
foreach (var s1 in spisok1)
{
    System.Console.WriteLine(s1);     
}

System.Console.WriteLine();
System.Console.WriteLine("After REMOVE:");
// Remove 
spisok1.RemoveAt(2);
foreach (var s1 in spisok1)
{
    System.Console.WriteLine(s1);     
}
System.Console.WriteLine();
System.Console.WriteLine("Alphabet sort:");
 spisok1.Sort();
 foreach (var it in spisok1)
 {
    System.Console.WriteLine(it);
 }

 System.Console.WriteLine();
 System.Console.WriteLine("<--After reversed-->");
 spisok1.Reverse();
 foreach (var it in spisok1)
 {
    System.Console.WriteLine(it);
 }
System.Console.WriteLine();
System.Console.WriteLine();
//Obyedineniye massiva v masiv:

List<string> newList = new List<string>(spisok1){};
foreach (var item in newList)
{
    System.Console.WriteLine(item);
}

//Opredelit Index
System.Console.WriteLine("Opredelyaem index :applee:");
System.Console.WriteLine(spisok1.IndexOf("applee"));

//Udalyaem element s Lengh = 5;
System.Console.WriteLine();
spisok1.RemoveAll(e=> e.Length == 5);
foreach (var it in spisok1)
{
    System.Console.WriteLine(it);
}

//17. Podschitvaem

//19 otsort spisok v obratnom poryadke
System.Console.WriteLine();
System.Console.WriteLine("<========================>");
 spisok1.Sort();
 foreach (var it in spisok1)
 {
    System.Console.WriteLine(it);
 }

 System.Console.WriteLine();
 System.Console.WriteLine("<--After reversed-->");
 spisok1.Reverse();
 foreach (var it in spisok1)
 {
    System.Console.WriteLine(it);
 }
System.Console.WriteLine();
System.Console.WriteLine();

//20 spisok v odnu stroku
string concat = string.Join(" , ", spisok1);
System.Console.WriteLine(spisok1 +concat);
