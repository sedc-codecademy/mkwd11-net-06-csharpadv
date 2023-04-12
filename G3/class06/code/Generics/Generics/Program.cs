using Generics.Helpers;
using Generics.Models;

//List<string> strings = new List<string>() { "str1", "str2", "str3" };
//List<int> ints = new List<int>() { 5, 22, -18 };
//List<bool> bools = new List<bool>() { true, false, false, true };

//var listHelper = new NoneGenericListHelper();

//listHelper.GoTroughSrings(strings);
//listHelper.GoTroughIntegers(ints);

//var genericListHelperForStrings = new GenericListHeper<string>();
//genericListHelperForStrings.GetInfoFor(strings);

//var genericListHelperForBooleans = new GenericListHeper<bool>();
//genericListHelperForBooleans.GetInfoFor(bools);


//var genericMethodHelpers = new GenericMethodHelpers();
//genericMethodHelpers.GoTrough(strings);
//genericMethodHelpers.GoTrough(ints);
//genericMethodHelpers.GoTrough(bools);




var OrderDb = new GenericDb<Order>();
var ProductDb = new GenericDb<Product>();


OrderDb.Insert(new Order() { Id = 1, Address = "Bob street 29", Receiver = "Bob" });
OrderDb.Insert(new Order() { Id = 2, Address = "Jill street 31", Receiver = "Jill" });
OrderDb.Insert(new Order() { Id = 3, Address = "Greg street 11", Receiver = "Greg" });

ProductDb.Insert(new Product() { Id = 1, Description = "For gaming", Title = "Mouse" });
ProductDb.Insert(new Product() { Id = 2, Description = "Mechanical", Title = "Keyboard" });
ProductDb.Insert(new Product() { Id = 3, Description = "64GB", Title = "USB" });

OrderDb.PrintAll();
ProductDb.PrintAll();


Console.ReadLine();