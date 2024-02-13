using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_CodeWars
{
    internal static class DetectarIsogram
    {

        public static bool DetectarIso(string Cadena)
        {
            char[] c = Cadena.ToCharArray();


            for (int i =0; i < c.Length; i++)
            {
                char ch = c[i];
                int indiceSuperior = i+1;

                for (int j=indiceSuperior; j < c.Length; j++)
                {

                    if (ch == c[j] || Char.ToLower(ch) == c[j] || ch == Char.ToLower(c[j]))
                    {
                        return false;

                    }
                   
                }

            }
           
            return true;

        }


        public static bool DetectarIsoFormaCorta(string Cadena)
        {

            return Cadena.ToLower().Distinct().Count() == Cadena.Length;

        }





    }
}
