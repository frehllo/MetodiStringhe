using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodiStringhe
{
    public class ClasseStringhe
    {
        public static bool Uguale(string stringa1, string stringa2)
        {
            if(stringa1 == stringa2)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public static bool ContieneChar(string stringa)
        {
            int maiuscole = 0;
            for (int i = 0; i < stringa.Length; i++)
            {
                if(Char.IsUpper(stringa[i]) == true)
                {
                    maiuscole++;
                }
            }
            if (maiuscole > 0)
            {
                return true;
            }else
            {
                return false;
            }


        }
    }
}
