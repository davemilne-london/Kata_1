using System;

namespace Kata_1_Code
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static string TranslateToRoman(uint Value)
        {
            var romanresult = "";

            while (Value > 0)
            {
                romanresult += "I";
                Value -= 1;
            }

            return romanresult;

        }
    }
}
