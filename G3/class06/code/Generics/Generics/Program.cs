using Generics.Helpers;

List<string> strings = new List<string>() { "str1", "str2", "str3" };
List<int> ints = new List<int>() { 5, 22, -18 };
List<bool> bools = new List<bool>() { true, false, false, true };

var listHelper = new NoneGenericListHelper();

listHelper.GoTroughSrings(strings);
listHelper.GoTroughIntegers(ints);

var genericListHelperForStrings = new GenericListHeper<string>();
genericListHelperForStrings.GetInfoFor(strings);

var genericListHelperForBooleans = new GenericListHeper<bool>();
genericListHelperForBooleans.GetInfoFor(bools);


var genericMethodHelpers = new GenericMethodHelpers();
genericMethodHelpers.GoTrough(strings);
genericMethodHelpers.GoTrough(ints);
genericMethodHelpers.GoTrough(bools);

Console.ReadLine();