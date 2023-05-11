namespace SOLID
{
    /*
         *** LISKOV SUBSTITUTION PRINCIPLE ***

         => LSP states that the child class should be perfectly substitutable for their parent class.
      */


    #region Without LSP
    // BAD EXAMPLE
    public class Trianglee
    {
        public virtual string GetShape()
        {
            return "Triangle";
        }
    }

    public class Circlee : Trianglee
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }

    public class AppStartLSP
    {
        public static void Main()
        {
            Trianglee triangle = new Circlee();
            Console.WriteLine(triangle.GetShape()); // will print Circle
        }
    }

    #endregion

    #region With LSP
    // GOOD EXAMPLE

    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class Circle : Shape
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }

    public class AppLSP
    {
        public static void Main()
        {
            Shape triangle = new Triangle();
            Console.WriteLine(triangle.GetShape()); // will print Triangle
        }
    }
    #endregion

}
