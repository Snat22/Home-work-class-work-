List<string> spisok = new List<string>(){"Salmon","Maruf"};
List<string> spisok2 = new List<string>(){"Abdughafor","Apple"};
spisok.AddRange(spisok2);
foreach (var it in spisok)
{
    System.Console.WriteLine(it);
}