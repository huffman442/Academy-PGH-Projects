using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create morse code library
            string[] morseLibrary = new string[27];
            morseLibrary[0] = ".-";
            morseLibrary[1] = "-...";
            morseLibrary[2] = "-.-.";
            morseLibrary[3] = "-..";
            morseLibrary[4] = ".";
            morseLibrary[5] = "..-.";
            morseLibrary[6] = "--.";
            morseLibrary[7] = "....";
            morseLibrary[8] = "..";
            morseLibrary[9] = ".---";
            morseLibrary[10] = "-.-";
            morseLibrary[11] = ".-..";
            morseLibrary[12] = "--";
            morseLibrary[13] = "-.";
            morseLibrary[14] = "---";
            morseLibrary[15] = ".--.";
            morseLibrary[16] = "--.-";
            morseLibrary[17] = ".-.";
            morseLibrary[18] = "...";
            morseLibrary[19] = "-";
            morseLibrary[20] = "..-";
            morseLibrary[21] = "...-";
            morseLibrary[22] = ".--";
            morseLibrary[23] = "-..-";
            morseLibrary[24] = "-.--";
            morseLibrary[25] = "--..";
            morseLibrary[26] = " ";

            //Map for conversion
            string map = "abcdefghijklmnopqrstuvwxyz ";

            //User input
            Console.WriteLine("What string would you like to convert?(no special characters a-z only)");
            string toConvert = Console.ReadLine();

            string converted = "";
            toConvert = toConvert.ToLower();
            for (int i = 0; i < toConvert.Length; i++)
            {
                int mapIndex = map.IndexOf(toConvert[i]);
                converted += $"{morseLibrary[mapIndex]} ";
            }


            //Output Converted String
            Console.WriteLine(converted);

            Console.ReadLine();
        }
    }
}
