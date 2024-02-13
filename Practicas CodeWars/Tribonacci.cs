using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_CodeWars
{
    internal static class Tribonacci
    {

        public static double[]? TribonacciSeries(double[] signature, int n)
        {        

            if (n != 0 && n>0) { 
            
                if (n<3)
                {
                    double[] resultX = new double[n];

                    for (int i = 0; i<n; i++)
                    {

                        resultX[i] = signature[i];
                    }

                    return resultX;

                }
                else
                {
                    double[] result = new double[n];

        
                        result[0] = signature[0];
                        result[1] = signature[1];
                        result[2] = signature[2];
           


                    for (int i = 3; i < n; i++)
                    {
                        result[i] = result[i - 1] + result[i - 2] + result[i - 3];


                    }

                    return result;


                }



            }
            else
            {
                double[] array = new double[] { };

                return array;

            }

            

        }

    }
}
