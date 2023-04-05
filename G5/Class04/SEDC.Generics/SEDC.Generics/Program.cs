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
Console.WriteLine("===== Generic DB =======");

GenericDb<Order> orderDb = new GenericDb<Order>();
GenericDb<Product> productDb = new GenericDb<Product>();

//GenericDb<Test> testDb = new GenericDb<Test>();

orderDb.Insert(new Order() { Id = 1, Address = "Bulevar Jane Sandanski br.10", Receiver = "Angel" });
orderDb.Insert(new Order() { Id = 2, Address = "Bulevar Partizanski Odredi br.3", Receiver = "Dragisha" });
orderDb.Insert(new Order() { Id = 3, Address = "Rudnicka br.2", Receiver = "Mitko" });

Console.WriteLine("==== Order list: =====");

orderDb.PrintAll();


productDb.Insert(new Product() { Id = 1, Title = "USB", Description="USB 64GB"});
productDb.Insert(new Product() { Id = 2, Title = "Keyboard", Description="Mechanic"});
productDb.Insert(new Product() { Id = 3, Title = "Mouse", Description="Gaming"});

Console.WriteLine("==== Product list: =====");
productDb.PrintAll();

Console.WriteLine("===== Get by Id ======");

Console.WriteLine("===== Get by Id Order ======");
Console.WriteLine(orderDb.GetById(2).GetInfo());

Console.WriteLine("===== Get by Id Product ======");
Console.WriteLine(productDb.GetById(3).GetInfo());

Console.WriteLine("===== Remove by Id Product ======");
productDb.Remove(1);
productDb.PrintAll();

Console.WriteLine("===== Remove by Id Order ======");
orderDb.Remove(2);
orderDb.PrintAll();

Console.WriteLine("===== Get by Index Order ======");
Console.WriteLine(orderDb.GetByIndex(1).GetInfo());

Console.WriteLine("===== Get by Index Product ======");
Console.WriteLine(productDb.GetByIndex(0).GetInfo());

Console.ReadLine();
#endregion

