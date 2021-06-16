using System;
namespace UlamekBiblioteka
{
    public struct Ulamek :IComparable<Ulamek>
    {
        private int mianownik;

        //public Ulamek(int licznik, int mianownik = 1)
        //{
        //    if (mianownik == 0)
        //        //tworzenie wyjątku w konstruktorze, uniemożliwi stworzenie niepoprawnego obiektu ułamka
        //        throw new ArgumentException("Mianownik musi byc rozny od zera");
        //    this.Licznik = licznik;
        //    this.mianownik = mianownik;
        //}
        //tworzenie statycznych pól reprezentujących typowe wartości ułamka
        //utworzenie obiektu jest możliwe z jednym parametrem
        public static readonly Ulamek Zero = new Ulamek(0);
        public static readonly Ulamek Jeden = new Ulamek(1);
        public static readonly Ulamek Polowa = new Ulamek(1, 2);
        public static readonly Ulamek Cwierc = new Ulamek(1, 4);

        public static string Info()
        {
            return "Struktura ulamek";
        }
        public override string ToString()
        {
            return Licznik.ToString() + " / " + mianownik.ToString();
        }

        public readonly double ToDouble()
        {
            return Licznik / (double)mianownik;
        }

        public void Uprosc()
        {
            int a = Licznik;
            int b = mianownik;
            //NWD
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            Licznik /= a;
            mianownik /= a;
            if (Licznik * mianownik < 0)
            {
                Licznik = -Math.Abs(Licznik);
                mianownik = -Math.Abs(mianownik);
            }
            else
            {
                Licznik = Math.Abs(Licznik);
                mianownik = Math.Abs(mianownik);
            }
        }
        public Ulamek(int licznik, int mianownik = 1) : this()
        {
            this.Licznik = licznik;
            this.Mianownik = mianownik;
        }
        #region Wlasnosc
        public int Licznik { get; set; }
        //{
        //    get => licznik;
        //    set => licznik = value;
        //}
        public int Mianownik
        {
            get => mianownik;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Mianownik musi byc różny od zera!");
                }
                mianownik = value;

            }
        }

        #endregion
        #region Operatory arytmetyczne
        public static Ulamek operator -(Ulamek u)
        {
            return new Ulamek(-u.Licznik, u.Mianownik);
        }
        public static Ulamek operator +(Ulamek u)
        {
            return u;
        }
        public static Ulamek operator +(Ulamek u1, Ulamek u2)
        {
            Ulamek wynik = new Ulamek(u1.Licznik * u2.Mianownik + u2.Licznik * u1.Mianownik, u1.Mianownik * u2.Mianownik);
            wynik.Uprosc();
            return wynik;
        }
        public static Ulamek operator -(Ulamek u1, Ulamek u2)
        {
            Ulamek wynik = new Ulamek(u1.Licznik * u2.Mianownik - u2.Licznik * u1.Mianownik, u1.Mianownik * u2.Mianownik);
            wynik.Uprosc();
            return wynik;
        }
        public static Ulamek operator *(Ulamek u1, Ulamek u2)
        {
            Ulamek wynik = new Ulamek(u1.Licznik * u2.Licznik, u1.Mianownik * u2.Mianownik);
            wynik.Uprosc();
            return wynik;
        }
        public static Ulamek operator /(Ulamek u1, Ulamek u2)
        {
            Ulamek wynik = new Ulamek(u1.Licznik * u2.Mianownik, u1.Mianownik * u2.Licznik);
            wynik.Uprosc();
            return wynik;
        }
        #endregion
        #region Operatory porownania
        public static bool operator ==(Ulamek u1, Ulamek u2)
        {
            return (u1.ToDouble() == u2.ToDouble());
        }
        public static bool operator !=(Ulamek u1, Ulamek u2) {
            return !(u1 == u2);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Ulamek)) return false;
            Ulamek u = (Ulamek)obj;
            return (this == u);
        }
        public override int GetHashCode()
        {
            return Licznik^Mianownik;
        }

        public int CompareTo(Ulamek other)
        {
            double roznica = this.ToDouble() - other.ToDouble();
            if (roznica != 0) roznica /= Math.Abs(roznica);
            return (int)roznica;
        }

        public static bool operator >(Ulamek u1, Ulamek u2)
        {
            return (u1.ToDouble() > u2.ToDouble());
        }
        public static bool operator >=(Ulamek u1, Ulamek u2)
        {
            return (u1.ToDouble() >= u2.ToDouble());
        }
        public static bool operator <(Ulamek u1, Ulamek u2)
        {
            return (u1.ToDouble() < u2.ToDouble());
        }
        public static bool operator <=(Ulamek u1, Ulamek u2)
        {
            return (u1.ToDouble() <= u2.ToDouble());
        }


        #endregion
        #region Operatorzy Konwersji
        //operator rzutowania jawnego
        public static explicit operator double (Ulamek u)
        {
            return u.ToDouble();
        }
        // operator rzutowania niejawnego
        public static implicit operator Ulamek(int n)
        {
            return new Ulamek(n);
        }
        #endregion
    }
}
