using System;

namespace Funciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int numeros, con = 0;
            
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese numero: ");
                numeros = int.Parse(Console.ReadLine());
                
                if (par(numeros))
                {
                    con++;
                }
            }
            Console.WriteLine("Los numeros pares son: " + con);
        }
        static bool par(int n1){
            if (n1 % 2 == 0){
                return true;
            }else
            {
                return false;
            }
        }
    }
}
