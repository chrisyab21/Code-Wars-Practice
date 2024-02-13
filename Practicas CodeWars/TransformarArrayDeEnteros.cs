using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practicas_CodeWars
{
    internal static class TransformarArrayDeEnteros
    {



       public static String TransformarArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsDigit(numbers[i]) == false)
                {
                    return "Introduza valores de un digito";

                }

            }

            string cadena="";

            for (int i = 0; i< numbers.Length; i++)
            {
                if (i==0)
                {
                    cadena = $"({cadena}";

                }

                cadena = $"{cadena}{numbers[i].ToString()}";

                if (i==2)
                {
                    cadena = $"{cadena}) ";

                }

                if (i == 5)
                {
                    cadena = $"{cadena}-";

                }

            }

            return cadena;
        }

        public static bool IsDigit(int num)
        {
            if (num==0)
            {
                return true;
            }

            if (num == 1 || num ==-1)
            {
                return true;
            }

            if (num == 2 || num ==-2)
            {
                return true;
            }

            if (num == 3 || num ==-3)
            {
                return true;
            }

            if (num == 4 || num ==-4)
            {
                return true;
            }
            if (num == 5 || num ==-5)
            {
                return true;
            }

            if (num == 6 || num ==-6)
            {
                return true;
            }

            if (num == 7 || num ==-7)
            {
                return true;
            }


            if (num == 8 || num ==-8)
            {
                return true;
            }


            if (num == 9 || num ==-9)
            {
                return true;
            }


            return false;
        }



    }
}
