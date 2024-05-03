using programa3._2.Class;
using System;

class Program
{
    static void Main(string[] args)
    {
        double nota1, nota2, nota3;
        bool inputCorrecto = false;

        do
        {
            Console.WriteLine("Ingrese la primera nota:");
            if (!double.TryParse(Console.ReadLine(), out nota1))
            {
                Console.WriteLine("Error: Por favor ingrese un número válido.");
            }
            else
            {
                inputCorrecto = true;
            }
        } while (!inputCorrecto);

        inputCorrecto = false;

        do
        {
            Console.WriteLine("Ingrese la segunda nota:");
            if (!double.TryParse(Console.ReadLine(), out nota2))
            {
                Console.WriteLine("Error: Por favor ingrese un número válido.");
            }
            else
            {
                inputCorrecto = true;
            }
        } while (!inputCorrecto);

        inputCorrecto = false;

        do
        {
            Console.WriteLine("Ingrese la tercera nota:");
            if (!double.TryParse(Console.ReadLine(), out nota3))
            {
                Console.WriteLine("Error: Por favor ingrese un número válido.");
            }
            else
            {
                inputCorrecto = true;
            }
        } while (!inputCorrecto);

        if (PromedioAlumno.EsPromocionado(nota1, nota2, nota3))
        {
            Console.WriteLine("Promocionado");
        }

        Console.ReadLine();
    }
}
