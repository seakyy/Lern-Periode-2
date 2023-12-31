﻿namespace Kryptoverfahren_test
{
    internal class Program
    {
        static string CaesarVerschlüsselung(string text, int schluessel)
        {
            string verschlüsselterText = "";

            foreach (char alphabet in text)
            {
                if (char.IsLetter(alphabet))
                {
                    char verschlüsselterAlphabet = (char)(alphabet + schluessel);

                    if ((char.IsUpper(alphabet) && verschlüsselterAlphabet > 'Z') ||
                        (char.IsLower(alphabet) && verschlüsselterAlphabet > 'z'))
                    {
                        verschlüsselterAlphabet = (char)(verschlüsselterAlphabet - 26);
                    }

                    verschlüsselterText += verschlüsselterAlphabet;
                }
                else
                {
                    verschlüsselterText += alphabet;
                }
            }

            return verschlüsselterText;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Haben Sie einen klaren[1] oder verschlüsselten Text[2]: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);

            if (auswahl == 1 || auswahl == 2)
            {
                int min = 1;
                int max = 26;

                if (auswahl == 1)
                {
                    // Klartext
                    Console.WriteLine("Geben Sie Ihren Klartext ein: ");
                    string klartext = Console.ReadLine();
                    Console.WriteLine($"Geben Sie eine Zahl zwischen {min} und {max} ein: ");
                    int schlüssel = Convert.ToInt32(Console.ReadLine());

                    // Verschlüsselung
                    string verschlüsselterText = CaesarVerschlüsselung(klartext, schlüssel);
                    Console.WriteLine($"Verschlüsselter Text: {verschlüsselterText}");
                }
                else if (auswahl == 2)
                {
                    
                    // Verschlüsselter Text
                    Console.WriteLine($"Geben Sie Ihren verschlüsselten Text ein: ");
                    string verschlüsselterText = Console.ReadLine();
                    Console.WriteLine($"Geben Sie eine Zahl zwischen {min} und {max} ein: ");
                    int schlüssel = Convert.ToInt32(Console.ReadLine());

                    // Entschlüsselung
                    string entschlüsselterText = CaesarVerschlüsselung(verschlüsselterText, -schlüssel);
                    Console.WriteLine($"Entschlüsselter Text: {entschlüsselterText}");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
            }
        }
    }
}
