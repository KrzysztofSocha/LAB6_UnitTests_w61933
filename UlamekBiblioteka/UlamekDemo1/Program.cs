using System;
using UlamekBiblioteka;

namespace UlamekDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Ulamek.Info());
            //Ulamek u13 = new Ulamek(1, 3);
            //Ulamek u2 = new Ulamek(2);
            //Ulamek u0 = Ulamek.Zero;
            //Ulamek u12 = Ulamek.Polowa;

            //Console.WriteLine(u13.ToString());
            //Console.WriteLine(u2.ToString());
            //Console.WriteLine(u0.ToString());
            //Console.WriteLine(u12.ToString());
            //Ulamek uP = new Ulamek() { Licznik = 1, Mianownik = 2 };
            //Console.WriteLine("Ulamek polowa: ");
            //Console.WriteLine(uP);
            //Ulamek uP1 = new Ulamek();
            //uP1.Licznik = 1;
            //uP1.Mianownik = 2;
            //Console.Write("Ułamek połowa: ");
            //Console.WriteLine(uP1);
            //Console.WriteLine(uP1.Licznik);
            //Console.WriteLine(uP1.Mianownik);
            //Console.WriteLine(uP1 + u13);
            //Console.WriteLine(uP1 - u13);
            //Console.WriteLine(uP1 * u13);
            //Console.WriteLine(uP1 / u13);

            //Console.WriteLine(u12 == u13);
            //Console.WriteLine(u12 != u13);
            //Console.WriteLine(u12 < u13);
            //Console.WriteLine(u12 <= u13);
            //Console.WriteLine(u12 > u13);
            //Console.WriteLine(u12 >= u13);
            //Console.WriteLine(u12.Equals(u13));
            //Console.WriteLine(u12.GetHashCode());
            //Console.WriteLine(u13.GetHashCode());
            double r = (double)Ulamek.Polowa;
            Console.WriteLine(r);
            Ulamek u1 = 2;
            Console.WriteLine(u1);
            Ulamek[] tablica = new Ulamek[10];
            for (int i = 0; i < tablica.Length; ++i)
                tablica[i] = new Ulamek(1, i + 1);
            
            foreach (Ulamek u in tablica)
                Console.WriteLine(u + " = " + (double)u);
            
            ;
            Console.WriteLine("Tablica po sortowaniu: ");
            Array.Sort(tablica);
            foreach (Ulamek u in tablica)
                Console.WriteLine(u + " = " + (double)u);
            
        }
    }
}
