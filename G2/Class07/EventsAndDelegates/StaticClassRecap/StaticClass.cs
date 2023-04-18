namespace StaticClassRecap
{
    public static class StaticClass
    {
        public static string Text { get; set; }

        static StaticClass()
        {
            Text = "Static classes recap";
        }

        public static void ToUpperCase(this string text)
        {
            Console.WriteLine(text.ToUpper());
        }
    }
}
