using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Punkt
    {
        private int x;

        private int y;

        private int xp, yp;

        public Punkt(int wsp_x, int wsp_y)

        {
            x = wsp_x; y = wsp_y;
        }
        public void Wyswietl()
        {
            Console.WriteLine("x = " + x + " y = " + y ); 
        }
        public void przesun(int dod_x, int dod_y)
        {
            x = x + dod_x;
            y = y + dod_y;
            xp = dod_x;
            yp = dod_y;
            
        }
       public void Cofnij_Przesun()
        {
            x = x - xp;
            y = y - yp;
        }
        public static double Odleglosc2punktow(Punkt p1, Punkt p2)
        {
           return Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
        }
       
    }
        
        
        
}
