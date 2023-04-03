using osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztaly_Konyv
{
    internal class Konyv
    {
        long isbnSzam;
        string szerzoK;
        string muCime;
        int kiadasiEv;
        string nyelv;
        bool enciklopedia;
        char eBook;

        long IsbnSzam
        {
            get { return isbnSzam; }
            set { isbnSzam = value; }
        }
        string SzerzoK
        {
            get { return szerzoK; }
            set { szerzoK = value; }
        }
        string MuCime
        {
            get { return muCime; }
            set { muCime = value; }
        }
        int KiadasiEv
        {
            get { return kiadasiEv; }
            set { kiadasiEv = value; }
        }
        string Nyelv
        {
            get { return nyelv; }
            set { nyelv = value; }
        }
        bool Enciklopedia
        {
            get { return enciklopedia; }
            set { enciklopedia = value; }
        }
        char EBook
        {
            get { return eBook; }
            set { eBook = value; }
        }
        public Konyv(long isbnSzam, string szerzoK, string muCime, int kiadasiEv, string nyelv, bool enciklopedia, char eBook)
        {
            IsbnSzam = isbnSzam;
            SzerzoK = szerzoK;
            MuCime = muCime;
            KiadasiEv = kiadasiEv;
            Nyelv = nyelv;
            Enciklopedia = enciklopedia;
            EBook = eBook;
        }
        public override string ToString()
        {
            return $"Könyv címe: {muCime}| Szerző: {szerzoK}| Nyelv: {nyelv}| Kiadás éve: {kiadasiEv}| ISBN szám: {isbnSzam}| Enciklopédia: {enciklopedia}| eBook: {eBook}";
        }

        ~Konyv()//destruktor
        {
            Console.WriteLine("A destruktor tette a dolgát....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Konyv osztály
            //isbnSzam
            //szerzoK
            //muCime
            //kiadasiEv
            //nyelv
            //enciklopedia - bool
            //eBook - char (i/n)
            bool folytat = false;
            Konyv valami = new Konyv();
            do
            {
                try
                {
                    folytat = true;
                }
                catch (SajatException e)
                {
                    Console.WriteLine($"Hiba: {e}");
                }
            } while (!folytat);
            Console.ReadLine();
        }
    }
}
