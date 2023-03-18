using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(3, 4);
            Punkt p2 = new Punkt(-1, 5);
            p1.Wyswietl();
            p1.przesun(1, 2);
            p1.Wyswietl();
            p1.Cofnij_Przesun();
            p1.Wyswietl();
            Console.WriteLine(Punkt.Odleglosc2punktow(p1, p2));





        }    

    }
}
