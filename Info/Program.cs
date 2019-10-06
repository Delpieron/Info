using System;
using System.Diagnostics;
using System.Text;

namespace Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //turn on stopwatch
            Stopwatch stopwatch = new Stopwatch();
            
            //enter text
            Console.WriteLine("Wpisz text");
            string text = Console.ReadLine();

            stopwatch.Start();
            
            //array text and array to lower declaration
            char[] arr = text.ToCharArray();
            char[] arrDown = text.ToLower().ToCharArray();
            
            //variables for calculations
            int counter = 0;
            int Up = 0;
            int Down = 0;
            //checking if there are spaces in text or lower case chars;
            for (int i =0;i<text.Length; i++)
            {
                if (text[i] == ' ')//look for spaces
                    counter++;
                else{                         // if char is not a space then look for small and big letters
                    if (arr[i] == arrDown[i])
                    {
                        Down++;
                    }
                    else
                    {
                        Up++;
                    }
                }
            }
            //check if in the entered text is "ok" phrase
            bool result = text.Contains("ok");

            //how long took to end code
                        stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;

            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Czas wpisania textu: {DateTime.Now} ");
            Console.WriteLine($"***{text}***");
            Console.WriteLine($"Ilość spacji : {counter}");
            Console.WriteLine($"W tekscie {(result ? "wystepuje slowo ok" : "nie wystepuje slowo ok")}");
            Console.WriteLine($"Ilość wielkich liter: {Up}");
            Console.WriteLine($"Ilość małych liter: {Down} ");
            Console.WriteLine($"Czas wykonania kodu: {time.Milliseconds} ms");    
                

        }
    }
}
