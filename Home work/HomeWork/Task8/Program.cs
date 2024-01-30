List<string> find = new List<string>(){"Salmon","Amirjon","Ston","Iskandar"};
var yoft = find.Find(e=> e.Length < 5 );
System.Console.WriteLine($"Find: {yoft}");