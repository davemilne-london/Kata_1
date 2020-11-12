using System;
using System.Text;

namespace Kata_1_Code
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Integer: ");
            if (uint.TryParse(Console.ReadLine(), out var val))
            {
                Console.WriteLine($"Your Roman Numeral is {TranslateToRoman(val)}");
            }
            else
            {
                Console.WriteLine("That's not an unsigned integer!");
            };            
        }


        public static string TranslateToRoman(uint Value)
        {
            var romanResult = new StringBuilder();

            while (Value > 0)
            {

                if (Value >= 1000)
                {
                    romanResult.Append("M");
                    Value -= 1000;
                }
                else if (Value >= 900)
                {
                    romanResult.Append("CM");
                    Value -= 900;
                }
                else if (Value >= 500)
                {
                    romanResult.Append("D");
                    Value -= 500;
                }
                else if (Value >= 400)
                {
                    romanResult.Append("CD");
                    Value -= 400;
                }
                else if (Value >= 100)
                {
                    romanResult.Append("C");
                    Value -= 100;
                }
                else if (Value >= 90)
                {
                    romanResult.Append("XC");
                    Value -= 90;
                }
                else if (Value >= 50)
                {
                    romanResult.Append("L");
                    Value -= 50;
                }
                else if (Value >= 40)
                {
                    romanResult.Append("XL");
                    Value -= 40;
                }
                else if (Value >= 10)
                {
                    romanResult.Append("X");
                    Value -= 10;
                }
                else if(Value == 9)
                {
                    romanResult.Append("IX");
                    Value -= 9;
                }
                else if (Value == 4)
                {
                    romanResult.Append("IV");
                    Value -= 4;
                }                
                else if (Value >= 5)
                {
                    romanResult.Append("V");
                    Value -= 5;
                }
                else
                {
                    romanResult.Append("I");
                    Value -= 1;
                }
            }

            return romanResult.ToString();

        }
    }
}
