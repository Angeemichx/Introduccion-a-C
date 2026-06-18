using System;

class Calculadora
{
    static void Main()
    {
        Console.Write("Ingrese un número (float): ");
        float angulo = float.Parse(Console.ReadLine());
        
        Console.WriteLine($"El ángulo ingresado es: {angulo}");
    }
}
