using SEDC.Generics.Domain.Models;
using SEDC.Generics.Helpers;


#region Generic Helpers
List<string> strings = new List<string>() { "str1", "str2", "str3" };
List<int> integer = new List<int> { 1, 2, 3 };
List<bool> bolean = new List<bool> { true, false,true,true,false };

Console.WriteLine("======= String ======");

GenericListHelpers<string>.ListGenrericMethod(strings);

Console.WriteLine("======= Integer ======");

GenericListHelpers<int>.ListGenrericMethod(integer);

Console.WriteLine("======= Boolean ======");

GenericListHelpers<bool>.ListGenrericMethod(bolean);
#endregion

#region Generic Classes
Console.WriteLine("===== DB =======");

GenericDb<Order> orderDb = new GenericDb<Order>();
GenericDb<Product> productDb = new GenericDb<Product>();

//GenericDb<Test> testDb = new GenericDb<Test>();

Console.ReadLine();
#endregion

