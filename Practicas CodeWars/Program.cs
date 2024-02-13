// See https://aka.ms/new-console-template for more information
using Practicas_CodeWars;

Console.WriteLine("Hello, World!");


int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,0};

String resultado = TransformarArrayDeEnteros.TransformarArray(numeros);

Console.WriteLine(resultado);

bool resultado2 = TransformarArrayDeEnteros.IsDigit(-9);

Console.WriteLine(resultado2);



bool resultadoPangram = DetectarPangram.Detectar("qweRtYuiopasdFghjklzxcvbnm");


if (resultadoPangram == true)
{
    Console.WriteLine("La cadena que proporciono SI es un pangram");

}
else
{
    Console.WriteLine("La cadena que proporciono NO es un pangram");

}


Console.WriteLine(DetectarIsogram.DetectarIso("Hugos"));

Console.WriteLine(DetectarIsogram.DetectarIsoFormaCorta("HugGos"));

Console.WriteLine(AlphabetPosition.Replace("The sunset sets at twelve o' clock."));


Console.WriteLine("Coloque un arreglo para obtener la serie Tribonacci");
string? dato1 = Console.ReadLine();
string? dato2 = Console.ReadLine();
string? dato3 = Console.ReadLine();

double[] inicio = new double[3] {int.Parse(dato1), int.Parse(dato2), int.Parse(dato3) };
Console.WriteLine("Coloque el numero de elementos que quiere obtener en serie Tribonacci");
string? cantidad = Console.ReadLine();

double[] resultadoTribonacci = Tribonacci.TribonacciSeries(inicio,int.Parse(cantidad));

for (int i=0;i<resultadoTribonacci.Length;i++)
{
    Console.Write(resultadoTribonacci[i] + " ");

}
