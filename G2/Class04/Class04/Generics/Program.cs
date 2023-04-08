List<int> numbers = new List<int>()
{
    234,5632,436,57,23,7873,65,2
};

List<string> names = new List<string>()
{
    "Bojan","Elena","Viktor","Slave","Leo","Kiril"
};

List<bool> booleans = new List<bool>()
{
    true,false,false,false,true,true,false,false,
};

//void PrintNumbers(List<int> listOfNumbers)
//{
//    foreach (int number in listOfNumbers)
//    {
//        Console.WriteLine(number);
//    }
//}

//void PrintStrings(List<string> listOfString)
//{
//    foreach (string word in listOfString)
//    {
//        Console.WriteLine(word);
//    }
//}

void PrintEveryType<Neshto>(List<Neshto> someList)
{
    foreach (Neshto item in someList)
    {
        Console.WriteLine(item);
    }
}

PrintEveryType(numbers);
Console.WriteLine("\n");
PrintEveryType(names);
Console.WriteLine("\n");
PrintEveryType(booleans);