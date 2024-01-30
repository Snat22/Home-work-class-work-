List<bool> values = new List<bool>(){true,true,true};
bool allTrue = values.All(e=> e == true);
System.Console.WriteLine("Are all the values in the list true? " +allTrue);