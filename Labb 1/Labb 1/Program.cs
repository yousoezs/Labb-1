using System;
using static System.Console;
using static System.Convert;

//skapa en konsollapplikation som tar en textsträng (string) som argument till Main eller uppmanar användaren mata in en sträng i konsollen.
//Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
//och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
//siffror förekommer där emellan.
//ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
//ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
//t.ex 95a9 är inte heller ett korrekt tal.

namespace Labb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "29535123p48723487597645723645";
            var temp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                Write(input[i]);
                for (int j = 0; j < input.Length; j++)
                {
                    if (int.TryParse(input, out int input1))
                    {
                        WriteLine(input1);
                    }
                }
            }
        }
    }
}