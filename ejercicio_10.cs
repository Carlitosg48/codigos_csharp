using System;

class ejercicio_10
{
    static void Main()
    {
        // Leer un número desde consola
        Console.Write("Ingresa un número: ");
        int n1 = int.Parse(Console.ReadLine());

        // Verificar si es positivo o negativo
        if (n1 > 0)
        {
            Console.WriteLine(n1 + " es positivo");
        }
        else
        {
            Console.WriteLine(n1 + " es negativo");
        }

        // Mostrar el número ingresado
        Console.WriteLine("Número ingresado: " + n1);
    }
}
