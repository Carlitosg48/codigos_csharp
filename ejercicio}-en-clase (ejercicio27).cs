/*
 Realizar un programa que determine la edad de una persona:
Niño < 12
Adolescente de 12 a 18
Adulto de 18 a 65
Adulto mayor > 65
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la edad de la persona:");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 12)
        {
            Console.WriteLine("Es un niño. Edad: " + edad);
        }
        else if (edad >= 12 && edad <= 18)
        {
            Console.WriteLine("Es un adolescente. Edad: " + edad);
        }
        else if (edad > 18 && edad <= 65)
        {
            Console.WriteLine("Es un adulto. Edad: " + edad);
        }
        else // edad > 65
        {
            Console.WriteLine("Es un adulto mayor. Edad: " + edad);
        }
    }
}
