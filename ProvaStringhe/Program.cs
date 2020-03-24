using System;

namespace ProvaStringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            //METODO UGUALI
            Console.WriteLine("prova Uguali");
            //scrittura e lettura prima stringa
            Console.Write("stringa 1: ");
            string stringa1 = Console.ReadLine();
            //scrittura e lettura seconda stringa
            Console.Write("stringa 2: ");
            string stringa2 = Console.ReadLine();
            //richiamo il metodo e scrittura risposta
            bool ris = MetodiStringhe.ClasseStringhe.Uguale(stringa1, stringa2);
            Console.WriteLine(ris);

            //METODO CONTIENECHAR
            Console.WriteLine("prova ContieneChar");
            //scrittura e lettura stringa
            Console.Write("stringa: ");
            string stringa = Console.ReadLine();
            //richiamo il metodo e scrittura risposta
            bool ris2 = MetodiStringhe.ClasseStringhe.ContieneChar(stringa);
            Console.WriteLine(ris2);
        }
    }
}
