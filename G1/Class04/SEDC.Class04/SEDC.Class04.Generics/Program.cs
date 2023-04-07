

using SEDC.Class04.Generics.Entities;

NonGenericHelper nonGenericHelper = new NonGenericHelper();

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<string> strings = new List<string> { "test", "non", "generic", "helper" };


//nonGenericHelper.GoThroughList(numbers);
//nonGenericHelper.GetInfoForList(numbers);

//nonGenericHelper.GoThroughList(strings);
//nonGenericHelper.GetInfoForList(strings);


//GenericHelper genericHelper = new GenericHelper();
//genericHelper.GoThroughList<string>(strings);
//genericHelper.GoThroughList<int>(numbers);
//genericHelper.GoThroughList<double>(new List<double> { 2.3, 3.4, 5.4});

//genericHelper.GetInfoForList<int>(numbers);
//genericHelper.GetInfoForList<string>(strings);


//genericHelper.WriteLine("Hello there");
//genericHelper.WriteLine(1);
//genericHelper.WriteLine('c');   
//genericHelper.WriteLine(3.2);



//GenericClass<string> genericClassString = new GenericClass<string>("Martin");
//GenericClass<int> genericClassInt = new GenericClass<int>(42);
//GenericClass<bool> genericClassBool  = new GenericClass<bool>(true);


//genericClassString.PrintPropertyAndType();
//genericClassInt.PrintPropertyAndType();
//genericClassBool.PrintPropertyAndType();



GenericDb<Product> productDb = new GenericDb<Product>();

productDb.Add(new Product { Id = 1, Title = "Book", Description = "C# Advanced" });
productDb.Add(new Product { Id = 2, Title = "Book 1", Description = "C# Basic" });
productDb.Add(new Product { Id = 3, Title = "Book 2", Description = "AJS" });


Console.WriteLine(productDb.GetItemsCount());


Product itemToDelete = productDb.GetById(2);
productDb.Remove(itemToDelete);

Console.WriteLine(productDb.GetItemsCount());



// For Homework: Create order classa and do the same for the Order class