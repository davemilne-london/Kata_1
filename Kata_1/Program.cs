using System;

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
            var romanResult = "";

            while (Value > 0)
            {

                if (Value >= 1000)
                {
                    romanResult += "M";
                    Value -= 1000;
                }
                else if (Value >= 900)
                {
                    romanResult += "CM";
                    Value -= 900;
                }
                else if (Value >= 500)
                {
                    romanResult += "D";
                    Value -= 500;
                }
                else if (Value >= 400)
                {
                    romanResult += "CD";
                    Value -= 400;
                }
                else if (Value >= 100)
                {
                    romanResult += "C";
                    Value -= 100;
                }
                else if (Value >= 90)
                {
                    romanResult += "XC";
                    Value -= 90;
                }
                else if (Value >= 50)
                {
                    romanResult += "L";
                    Value -= 50;
                }
                else if (Value >= 40)
                {
                    romanResult += "XL";
                    Value -= 40;
                }
                else if (Value >= 10)
                {
                    romanResult += "X";
                    Value -= 10;
                }
                else if(Value == 9)
                {
                    romanResult += "IX";
                    Value -= 9;
                }
                else if (Value == 4)
                {
                    romanResult += "IV";
                    Value -= 4;
                }                
                else if (Value >= 5)
                {
                    romanResult += "V";
                    Value -= 5;
                }
                else
                {
                    romanResult += "I";
                    Value -= 1;
                }
            }

            return romanResult;

        }
    }
}
