using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_CodeWars
{
    internal static class AlphabetPosition
    {


        public static string Replace(string Cadena)
        {
            string cadenaLimpia = Cadena.ToLower();
            string resultado="";

            for (int i =0; i < cadenaLimpia.Length; i++) {

                char c = cadenaLimpia[i];


                switch (c)
                {

                    case 'a':
                        resultado = resultado + "1 ";

                    break;

                    case 'b':
                        resultado = resultado + "2 ";
                    break;

                    case 'c':
                        resultado = resultado + "3 ";
                        break;

                    case 'd':
                        resultado = resultado + "4 ";
                        break;

                    case 'e':
                        resultado = resultado + "5 ";
                        break;

                    case 'f':
                        resultado = resultado + "6 ";
                        break;

                    case 'g':
                        resultado = resultado + "7 ";
                        break;

                    case 'h':
                        resultado = resultado + "8 ";
                        break;

                    case 'i':
                        resultado = resultado + "9 ";
                        break;

                    case 'j':
                        resultado = resultado + "10 ";
                        break;

                    case 'k':
                        resultado = resultado + "11 ";
                        break;

                    case 'l':
                        resultado = resultado + "12 ";
                        break;

                    case 'm':
                        resultado = resultado + "13 ";
                        break;

                    case 'n':
                        resultado = resultado + "14 ";
                        break;

                    case 'o':
                        resultado = resultado + "15 ";
                        break;

                    case 'p':
                        resultado = resultado + "16 ";
                        break;

                    case 'q':
                        resultado = resultado + "17 ";
                        break;

                    case 'r':
                        resultado = resultado + "18 ";
                        break;

                    case 's':
                        resultado = resultado + "19 ";
                        break;

                    case 't':
                        resultado = resultado + "20 ";
                        break;

                    case 'u':
                        resultado = resultado + "21 ";
                        break;

                    case 'v':
                        resultado = resultado + "22 ";
                        break;

                    case 'w':
                        resultado = resultado + "23 ";
                        break;

                    case 'x':
                        resultado = resultado + "24 ";
                        break;

                    case 'y':
                        resultado = resultado + "25 ";
                        break;

                    case 'z':
                        resultado = resultado + "26 ";
                        break;

                    default:                      
                    break;

                }


            }
            
            string resultadoLimpio = resultado.Trim();


            return resultadoLimpio;

        }
    }
}
