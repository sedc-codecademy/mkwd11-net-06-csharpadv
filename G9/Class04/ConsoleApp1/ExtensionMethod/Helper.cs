using System;
using System.Text;

namespace ExtensionMethod
{
    public static class Helper
    {
       public static void QuoteString(this string test)
        {
            Console.WriteLine("\"" + test + "\"");
        }

        /// <summary>
              /// Extension method za string, so ke primat int i ke se vikat Shorten Word
              /// stringov da go podelit na words(array)
              /// proverka dali parametaron int e pogolem od array.lenght
              /// proverka dali parametaron int e pogolem od 0
              /// return string so ke sodrzit zboroj kolku so e int parametarot
        /// </summary>
        /// <param name="sentece"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string ShortenWords 
            (this string sentece, int words)
        {

            if(words <= 0 )
            {
                throw new
                    ArgumentException($"You cannot shorthen the sentece by {words}");
            };

            if( sentece == "")
            {
                return "Empty string";
            }

            var splitedSentence = sentece.Split(' ');

            if(splitedSentence.Length < words )
            {
                return "You cannot split the sentece by this number";
            }

            var testArr = splitedSentence.Take(words).ToList();

            ////Use StringBuilder instead of concatination

            ////Concatination option

            //string conc = "";

            //foreach (var s in testArr)
            //{

            //    conc += s + " ";
            //}

            //return conc;

            ////StringBUilder option

            var str = new StringBuilder();

            foreach( var s in testArr )
            {

                str.Append( s + " " );
            }


            return str.ToString();
        }
    }
}