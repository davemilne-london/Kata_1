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

                if (Value >= 500)
                {
                    romanresult += "D";
                    Value -= 500;
                }
                else if (Value >= 400)
                {
                    romanresult += "CD";
                    Value -= 400;
                }
                else if (Value >= 100)
                {
                    romanresult += "C";
                    Value -= 100;
                }
                else if (Value >= 90)
                {
                    romanresult += "XC";
                    Value -= 90;
                }
                else if (Value >= 50)
                {
                    romanresult += "L";
                    Value -= 50;
                }
                else if (Value >= 40)
                {
                    romanresult += "XL";
                    Value -= 40;
                }
                else if (Value >= 10)
                {
                    romanresult += "X";
                    Value -= 10;
                }
                else if(Value == 9)
                {
                    romanresult += "IX";
                    Value -= 9;
                }
                else if (Value == 4)
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
