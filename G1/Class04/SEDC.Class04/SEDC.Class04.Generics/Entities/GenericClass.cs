namespace SEDC.Class04.Generics.Entities
{
    public class GenericClass<T>
    {
        public T MyGenericProperty { get; set; }


        public GenericClass(T property)
        {
            MyGenericProperty = property;
        }


        public void PrintPropertyAndType()
        {
            Console.WriteLine($"The property is of type {MyGenericProperty.GetType()} and it's value is {MyGenericProperty}");
        }
    }
}
