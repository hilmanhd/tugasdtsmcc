using System;

namespace DTSMCC
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int jamkedatangan;
            jamkedatangan = 9;
            if (jamkedatangan <= 8)
            {
                Console.WriteLine("Anda Tidak Terlambat Masuk Kantor!");
            }
            else
            {
                Console.WriteLine("Anda Terlambat Masuk Kantor!");
            }
        }

    }
}