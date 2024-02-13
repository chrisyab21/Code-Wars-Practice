using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_CodeWars
{
    internal static class DetectarPangram
    {


        public static bool Detectar(string Cadena) {


            if ((Cadena.Contains("A") || Cadena.Contains("a")) && (Cadena.Contains("B") || Cadena.Contains("b"))
                && (Cadena.Contains("C") || Cadena.Contains("c")) && (Cadena.Contains("D") || Cadena.Contains("d")) && (Cadena.Contains("E") || Cadena.Contains("e"))
                && (Cadena.Contains("F") || Cadena.Contains("f")) && (Cadena.Contains("G") || Cadena.Contains("g")) && (Cadena.Contains("H") || Cadena.Contains("h"))
                && (Cadena.Contains("I") || Cadena.Contains("i")) && (Cadena.Contains("J") || Cadena.Contains("j")) && (Cadena.Contains("K") || Cadena.Contains("k"))
                && (Cadena.Contains("L") || Cadena.Contains("l")) && (Cadena.Contains("M") || Cadena.Contains("m")) && (Cadena.Contains("N") || Cadena.Contains("n"))
                && (Cadena.Contains("O") || Cadena.Contains("o")) && (Cadena.Contains("P") || Cadena.Contains("p")) && (Cadena.Contains("Q") || Cadena.Contains("q"))
                && (Cadena.Contains("R") || Cadena.Contains("r")) && (Cadena.Contains("S") || Cadena.Contains("s")) && (Cadena.Contains("T") || Cadena.Contains("t"))
                && (Cadena.Contains("U") || Cadena.Contains("u")) && (Cadena.Contains("V") || Cadena.Contains("v")) && (Cadena.Contains("W") || Cadena.Contains("w"))
                && (Cadena.Contains("X") || Cadena.Contains("x")) && (Cadena.Contains("Y") || Cadena.Contains("y")) && (Cadena.Contains("Z") || Cadena.Contains("z"))

                ) {
             
              return true;
            
            }  

            return false;
        
        }
    }
}
