using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLib
{
    public partial class ModelGry
    {
        //pola/fields
        private readonly int wylosowana;                    //readonly oznacza, że nie można zmienić wartości poza konstruktorem
        public int ZakresOd { get; private set; }
        public int ZakresDo { get; private set; }
        public enum Stan { Trwa, Poddana, Odgadnieta }      //diagram stanu aplikacji pomaga przy podejmowaniu decyzji funkcjonalnych - np. pokazanie graczowi wylosowanej liczby na etapie, gdy się 'Poddaje'
        public Stan StanGry { get; private set; }

        public List<Ruch> Historia { get; private set; }


        //Konstruktor
        public ModelGry(int zakresOd = 1, int zakresDo = 100)
        {
            ZakresOd = Math.Min(zakresOd, zakresDo);
            ZakresDo = Math.Max(zakresOd, zakresDo);
            Random los = new Random();
            wylosowana = los.Next(ZakresOd, ZakresDo + 1); //+1, bo losowanie nie zawiera górnej liczby wskazanego zakresu - właściwość funckji Random
            StanGry = Stan.Trwa;
            Historia = new List<Ruch>();
        }

        //Metody
        public enum Odp { ZaMalo = -1, Trafione = 0, ZaDuzo = 1 };

        public Odp Ocena(int propozycja)
        {
            if (propozycja < wylosowana)
            {
                //Ruch r = new Ruch(propozycja, Odp.ZaMalo); //prawie równoważne z zapisem poniżej
                //Historia.Add(r);
                Historia.Add(new Ruch(propozycja, Odp.ZaMalo));
                return Odp.ZaMalo;
            }
            else if (propozycja > wylosowana)
            {
                Historia.Add(new Ruch(propozycja, Odp.ZaDuzo));
                return Odp.ZaDuzo;
            }
            else
            {
                Historia.Add(new Ruch(propozycja, Odp.Trafione));
                StanGry = Stan.Odgadnieta;
                return Odp.Trafione;
            }

        }

        public void Poddaj()
        {
            StanGry = Stan.Poddana;
        }

        public int Wylosowana
        {
            get
            {
                if (StanGry == Stan.Poddana || StanGry == Stan.Odgadnieta)
                    return wylosowana;
                else
                    throw new NotSupportedException("Nie wolno teraz Ci tej wartości udostępnić");
            }
        }

    }
}
