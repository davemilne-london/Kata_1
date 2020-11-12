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

                if (Value == 4)
                {
                    romanresult += "IV";
                    Value -= 4;
                }
                else if (Value >= 5)
                {
                    romanresult += "V";
                    Value -= 5;
                }
                else
                {
                    romanresult += "I";
                    Value -= 1;
                }
            }

            return romanresult;

        }
    }
}
