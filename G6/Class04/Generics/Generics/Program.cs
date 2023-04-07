using Generics;
using Generics.Domain;
using Generics.Domain.Models;

NonGenericListHelper nonGenericListHelper = new NonGenericListHelper();
List<string> strings = new List<string> { "Hello", "Bye", "Welcome" };
List<int> ints = new List<int> { 1, 2, 3 };
nonGenericListHelper.PrintInfoForStringsList(strings);
nonGenericListHelper.PrintListOfStrings(strings);
nonGenericListHelper.PrintListOfInts(ints);
nonGenericListHelper.PrintInfoForIntsList(ints);

//if GenericHelper was not static GenericListHelper<string> genHelper = new GenericListHelper<string>();
//genHelper.PrintList(strings);

GenericListHelper<string>.PrintList(strings);
GenericListHelper<string>.PrintListInfo(strings);
GenericListHelper<int>.PrintList(ints);
GenericListHelper<int>.PrintListInfo(ints);

//T will be replaced with Product for this instance of GenericDB
GenericDb<Product> productsDb = new GenericDb<Product>();
//T will be replaced with Order for this instance of GenericDB
GenericDb<Order> ordersDb = new GenericDb<Order>();

productsDb.Add(new Product { Id = 1, Title = "Pizza", Description = "Delicious pizza" });
productsDb.Add(new Product { Id = 2, Title = "Coca Cola", Description = "Delicious drink" });
//productsDb.Add(new Order()); ERROR -> productsDb is defined to work with type Product

productsDb.PrintAll();

productsDb.RemoveById(1);

productsDb.PrintAll();

ordersDb.Add(new Order { Id = 1, OrderedBy = "John", Address = "Street no.1" });

ordersDb.PrintAll();

