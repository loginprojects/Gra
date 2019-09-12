using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Proceduralnie
{
    

    class Program
    {
        static void Start()
        {
            Console.Clear();
            Console.WriteLine("Aplikacja Gra");
            Console.WriteLine("===========");
        }

        static int Losuj()
        {
            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); // do usunięcia w Release
#endif           
            Console.WriteLine("Wylosowałem liczbę z zakresu od 1 do 100. Odgadnij ją.");
            return wylosowana;
        }

        static void Main(string[] args)
        {
            Start()
        }


        static void Main1(string[] args)
        {
            // 1. Komputer losuje liczbę z  podanego zakresu
            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); // do usunięcia w Release
#endif           
            Console.WriteLine("Wylosowałem liczbę z zakresu od 1 do 100. Odgadnij ją.");

            Stopwatch czas = Stopwatch.StartNew();

            // powtarzaj wielokrotnie, aż odgadnie
            bool odgadniete = false;        // zmienna nazywana 'flagą' lub  'wartownikiem'; przy zastosowaniu słowa kluczowego 'break' deklarowanie i wykorzytanie zmiennej 'wartownika' jest niepotrzebne - mniej eleganckie, ale praktykowane rozwiązanie
            int licznik = 0;
            do
            {
                licznik++;
                // 2. Człowiek proponuje (odgaduje)
                Console.WriteLine("Podaj swoją propozycję: \n Wpisz 'koniec', aby zakończyć.");
                string napis = Console.ReadLine();
                if (napis == "koniec")
                {
                    Console.WriteLine("Szkoda, że mnie opuszczasz.");
                    return;
                }

                int propozycja = 0;
                try                                  // obsługa błędów. Warto sprawdzić w dokumentacji funkcji (w tym przypadku 'int.Parse'), jakie wyjątki mogą wystąpić
                {
                    propozycja = int.Parse(napis);
                }
                catch (FormatException)
                {

                    Console.WriteLine("Nie podano liczby. \n Spróbuj jeszcze raz");
                    continue; // zacznij od początku wykonywać pętlę
                }

                catch (OverflowException)
                {

                    Console.WriteLine("Przesadziłeś.\n Za duża liczba"); ;
                    continue;
                }

                catch (Exception)               //np. brak pamięci
                {
                    Console.WriteLine("Niezidentyfikowany wyjątek. Awaria");
                    Environment.Exit(1);        //gwatłowanie przerywam działanie programu
                }

                // 3. Komputer ocenia poropozycję
                if (propozycja < wylosowana)
                {
                    Console.WriteLine("Za mało");
                }
                else if (propozycja > wylosowana)
                {
                    Console.WriteLine("Za dużo");
                }
                else
                {
                    Console.WriteLine("Trafiłeś!");
                    //odgadniete = true;
                    break;
                }

            }
            //while (!odgadniete); // while ( propozycja != wylosowana )
            while (true); //kręć się w nieskończoność - aż do 'break'
            czas.Stop();



            // koniec powtarzania

            // 4. Wypisz statystyki gry
            Console.WriteLine($"Liczba ruchów: {licznik}");
            Console.WriteLine($"Czas gdy: {czas.Elapsed}");
        }
    }
}
