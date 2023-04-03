using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztaly_Konyv.Exceptions
{
    internal class SajatException : Exception
    {
        long hibasISBN;
        public long HibasISBN
        {
            get { return hibasISBN; }
            set { hibasISBN = value; }
        }
        public SajatException(long hibasISBN)
        {
            HibasISBN = hibasISBN;
        }
    }
}
