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

        static int WczytajPropozycję()
        {
            int propozycja = 0;
            Console.WriteLine("Podaj swoją propozycję: \n Wpisz 'koniec', aby zakończyć.");
            string napis = Console.ReadLine();
            while (true)
            {
                try                                  // obsługa błędów. Warto sprawdzić w dokumentacji funkcji (w tym przypadku 'int.Parse'), jakie wyjątki mogą wystąpić
                {
                    propozycja = int.Parse(napis);
                    break;
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
            }
            return propozycja;
        }

        static bool Ocena(int wylosowana, int propozycja)
        {
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
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Start();
            int x = Losuj();
            do
            {

                int y = WczytajPropozycję();

                //oceń propozycję
            } while (true);
        }


        
    }
}
