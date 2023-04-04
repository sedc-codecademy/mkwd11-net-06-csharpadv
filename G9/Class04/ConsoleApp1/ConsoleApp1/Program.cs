// See https://aka.ms/new-console-template for more information


using ConsoleApp1;
using ControledGenerics;
using Generics;
using System.Collections.Generic;
using ExtensionMethod;

//How to call static methods
#region
//StaticCll.PrintAllInt(new List<int>());

//var insds = StaticCll.PrintAllInt(new List<int>());

#endregion

//Non generic methods
#region

//NonGenericHelperClass nonGenericHelperClass = new NonGenericHelperClass();

//List<int> ints = new List<int>() {1,2,3,4,5 };
//List<string> str = new List<string> { "test", "Todor", "Sedc" };
//List<bool> boolList = new List<bool>() { true, false, true };
//nonGenericHelperClass.GetStringInfo(str);
//nonGenericHelperClass.GetIntInfo(ints);
//nonGenericHelperClass.PrintAllInt(ints);
//nonGenericHelperClass.PrintAllStrings(str);

#endregion

//Generic methods

#region

//GenericHelperClass<string> genericHelperClass = 
//    new GenericHelperClass<string>();

//genericHelperClass.PrintAll(str);
//genericHelperClass.GetInfo(str);

//GenericHelperClass<int> genericHelperClass1 = 
//    new GenericHelperClass<int>();    

//genericHelperClass1.PrintAll(ints);
//genericHelperClass1.GetInfo(ints);

//GenericHelperClass<bool> genericHelperClass2 =
//    new GenericHelperClass<bool>();
//genericHelperClass2.PrintAll(boolList);
//    genericHelperClass2.GetInfo(boolList);

#endregion

//Using generics within a certain scope

#region

GenericsDB<Order> order = 
    new GenericsDB<Order>();

GenericsDB<Product> product =
    new GenericsDB<Product>();

order.Add
  (new Order()
  { Id = 1, Address = "Test", Receiver = "Test2" }
  );

order.Add
  (new Order()
  { Id = 2, Address = "Bogomilska", Receiver = "Todor" }
  );

order.Add
  (new Order()
  { Id = 3, Address = "Krste Misirkov", Receiver = "Ljupco" }
  );

product.Add
    (new Product()
    { Id = 1, Title = "Rakija", Description = "Lozova" }
    );

product.Add
    (new Product()
    { Id = 2, Title = "Voda", Description = "Pelisterka" }
    );

product.Add
    (new Product()
    { Id = 3, Title = "Sopska", Description = "Mesana" }
    );

//If our method was not static, this was the way we whould print  all the elements of the list, and remove elements from the list

//var productList = product.List;
//var orderList = order.List;


//order.PrintAll(orderList);
//product.PrintAll(productList);

//product.Remove(2);


GenericsDB<Product>.Remove(2);

//Because this methods are static, we invoke them on the class

//GenericsDB<Product>.PrintAll();
//GenericsDB<Order>.PrintAll();



#endregion

#region


string sentece = "I love to eat hamburger too much on Monday";

var test = sentece.ShortenWords(3);

test.QuoteString();

Console.WriteLine();

#endregion





