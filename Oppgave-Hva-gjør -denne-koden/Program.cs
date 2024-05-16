namespace Oppgave_Hva_gjør__denne_koden
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Koden tar inn en string, og lagrer hvor mange ganger en bokstav har blitt brukt. 
            // Og så printer den det ut etterpå

            WhatDoesCodeRightAdjusted();
            void WhatDoesCodeRightAdjusted()
            {
                var range = 250;
                var counts = new int[range];
                string text = "something";
                while (!string.IsNullOrWhiteSpace(text))
                {
                    text = Console.ReadLine().ToLower();
                    foreach (var character in text ?? string.Empty)
                    {
                        counts[(int)character]++;
                    }
                    for (var i = 0; i < range; i++)
                    {
                        if (counts[i] > 0)
                        {
                            var character = (char)i;
                            // Putter det vi skal skrive ut i en egen variabelen så vi kan bruke lengden til den senere
                            string output = character + " - " + counts[i];

                            // Setter row posisjonen til bredden av terminalen - lengden til hva vi vil skrive ut - 1 (så den ikke er helt på kanten)
                            Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                            // Så printer vi det ut på den posisjonen
                            Console.WriteLine(output);
                        }
                    }
                }
            }
            void WhatDoesCodePercent()
            {
                var range = 250;
                var counts = new int[range];
                string text = "something";
                
                // Lager en variabel som skal holde hvor mange characters som blir lagt til
                int totalLetters = 0;
                while (!string.IsNullOrWhiteSpace(text))
                {
                    text = Console.ReadLine().ToLower();
                    foreach (var character in text ?? string.Empty)
                    {
                        // legger til +1 til totalLetters per nye character som blir lagt til
                        totalLetters++;
                        counts[(int)character]++;
                    }
                    for (var i = 0; i < range; i++)
                    {
                        if (counts[i] > 0)
                        {
                            var character = (char)i;
                            
                            // deler hvor mange av en character som er i counts på hvor mange totale characters det er og ganger det med 100 for å få prosen
                            // Vi må også caste det vi får ut av counts til datatypen double, fordi det er nå mulig å få decimal tall
                            // Og til slutt lagrer vi det vi har fått i letterPercent
                            var letterPercent = 100 * (double)counts[i] / totalLetters;
                            
                            // Vi printer da hvem character vi er på og procenten av totalle characters den er
                            // Vi bruker også metoden ToString("F2"), for å gjøre letterPercent til en string
                            // og vi sender med "F2" som en parameter sånn at den bare printer ut maks 2 av desimalene til letterPercent
                            Console.WriteLine(character + " Percent of letters: " + letterPercent.ToString("F2") + "%");
                        }
                    }
                }
            } 


            // Hvordan koden var når jeg først kopierte den inn
            void WhatDoesCode()
            {
                var range = 250;
                var counts = new int[range];
                string text = "something";
                while (!string.IsNullOrWhiteSpace(text))
                {
                    text = Console.ReadLine().ToLower();
                    foreach (var character in text ?? string.Empty)
                    {
                        counts[(int)character]++;
                    }
                    for (var i = 0; i < range; i++)
                    {
                        if (counts[i] > 0)
                        {
                            var character = (char)i;
                            Console.WriteLine(character + " - " + counts[i]);
                        }
                    }
                }
            }
           
        }
    }
}
