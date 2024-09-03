using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MorseConverter
{

    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Morse Code Converter");
            Console.WriteLine("--------------------");

            bool onkovalmis = true;
            while (onkovalmis == true)

            {
                Console.WriteLine("Would you like to convert to morse or ascii?");
                string valinta = Console.ReadLine();

                if (valinta == "morse")
                {
                    Console.WriteLine("Input what to translate to morse");
                    string totranslate = Console.ReadLine();
                    toMorse(totranslate);
                }
                else if (valinta == "ascii")
                {
                    Console.WriteLine("Input what to translate to ascii, use \"/\" for a space");
                    string totranslate = Console.ReadLine();
                    toAscii(totranslate);
                }
                else
                {
                    Console.Write("Not a valid choice");
                }
            }




            Console.ReadLine();
         }

        static void toMorse(string vastaus)
        { 
            Dictionary<string, string> morselista = new Dictionary<string, string>();
            morselista.Add("A", ".-");
            morselista.Add("B", "-...");
            morselista.Add("C", "-.-.");
            morselista.Add("D", "-..");
            morselista.Add("E", ".");
            morselista.Add("F", "..-.");
            morselista.Add("G", "--.");
            morselista.Add("H", "....");
            morselista.Add("I", "..");
            morselista.Add("J", ".---");
            morselista.Add("K", "-.-");
            morselista.Add("L", ".-..");
            morselista.Add("M", "--");
            morselista.Add("N", "-.");
            morselista.Add("O", "---");
            morselista.Add("P", ".--.");
            morselista.Add("Q", "--.-");
            morselista.Add("R", ".-.");
            morselista.Add("S", "...");
            morselista.Add("T", "-");
            morselista.Add("U", "..-");
            morselista.Add("V", "...-");
            morselista.Add("W", ".--");
            morselista.Add("X", "-..-");
            morselista.Add("Y", "-.--");
            morselista.Add("Z", "--..");
            morselista.Add("0", "-----");
            morselista.Add("1", ".----");
            morselista.Add("2", "..---");
            morselista.Add("3", "...--");
            morselista.Add("4", "....-");
            morselista.Add("5", ".....");
            morselista.Add("6", "-....");
            morselista.Add("7", "--...");
            morselista.Add("8", "---..");
            morselista.Add("9", "----.");
            morselista.Add(".", ".-.-.-");
            morselista.Add("?", "..--..");
            morselista.Add("!", "-.-.--");
            morselista.Add("-", "-...--");
            morselista.Add("&", ".-...");
            morselista.Add(" ", "/");

            string value = "";
            string lopullinenvastaus = "";

            foreach (char c in vastaus)
            {
                string testi = c.ToString();
                if (morselista.TryGetValue(testi.ToUpper(), out value))
                {
                    lopullinenvastaus = lopullinenvastaus + value + " ";
                }
                else
                {
                    Console.WriteLine("Input was not valid");
                }
            }
            Console.WriteLine(lopullinenvastaus);
        }

        static void toAscii(string vastaus)
        {
            Dictionary<string, string> morselista = new Dictionary<string, string>();
            morselista.Add(".-", "A");
            morselista.Add("-...", "B");
            morselista.Add("-.-.", "C");
            morselista.Add("-..", "D");
            morselista.Add(".", "E");
            morselista.Add("..-.", "F");
            morselista.Add("--.", "G");
            morselista.Add("....", "H");
            morselista.Add("..", "I");
            morselista.Add(".---", "J");
            morselista.Add("-.-", "K");
            morselista.Add(".-..", "L");
            morselista.Add("--", "M");
            morselista.Add("-.", "N");
            morselista.Add("---", "O");
            morselista.Add(".--.", "P");
            morselista.Add("--.-", "Q");
            morselista.Add(".-.", "R");
            morselista.Add("...", "S");
            morselista.Add("-", "T");
            morselista.Add("..-", "U");
            morselista.Add("...-", "V");
            morselista.Add(".--", "W");
            morselista.Add("-..-", "X");
            morselista.Add("-.--", "Y"); 
            morselista.Add("--..", "Z");
            morselista.Add("-----", "0");
            morselista.Add(".----", "1"); 
            morselista.Add("..---", "2");
            morselista.Add("...--", "3");
            morselista.Add("....-", "4");
            morselista.Add(".....", "5");
            morselista.Add("-....", "6");
            morselista.Add("--...", "7");
            morselista.Add("---..", "8");
            morselista.Add("----.", "9");
            morselista.Add(".-.-.-", "."); 
            morselista.Add("..--..", "?");
            morselista.Add("-.-.--", "!");
            morselista.Add("-...-", "-");
            morselista.Add(".-...", "&");
            morselista.Add("/", " ");

            string value = "";  
            string lopullinenvastaus = "";
            string[] morseyksikkö = vastaus.Split(' ');

            foreach (string c in morseyksikkö)
            {
                
                if (morselista.TryGetValue(c, out value))
                {
                    lopullinenvastaus = lopullinenvastaus + value;
                }
                else
                {
                    Console.WriteLine("Input was not valid.");
                }
            }
            Console.WriteLine(lopullinenvastaus);

        }

     }
}