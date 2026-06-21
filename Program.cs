using System;

class Calculadora
{
    static void Main(string[] args)
    {
        //Para que el usuario ingrese el número (se guarda como string)
        Console.Write ("Ingrese el ángulo a: ");

        //Se debe transformar el string escrito por el usuario a número decimal
        double angulo = double.Parse(Console.ReadLine()!);

        //Para pedirle la operación al usuario:
        Console.WriteLine("Las operaciones disponibles son:");
        Console.WriteLine(" sin, cos, tan");
        Console.WriteLine(" arcsin, arccos arctan");
        Console.WriteLine(" sinh, cosh, tanh");
        Console.Write("Ingrese la operación deseada: ");
        
        //Leer lo que escribe el usuario 
        string operacion = Console.ReadLine()!;

        //Calcular el resultado
        double resultado = 0;

        //Operaciones
        if (operacion == "sin")
            resultado = Math.Sin(angulo);
        else if (operacion == "cos")
            resultado = Math.Cos(angulo);
        else if (operacion == "tan")
            resultado = Math.Tan(angulo);

        else if (operacion == "arcsin")
            resultado = Math.Asin(angulo);
        else if (operacion == "arccos")
            resultado = Math.Acos(angulo);
        else if (operacion == "arctan")
            resultado = Math.Atan(angulo);

        else if (operacion == "sinh")
            resultado = Math.Sinh(angulo);
        else if (operacion == "cosh")
            resultado = Math.Cosh(angulo);
        else if (operacion == "tanh")
            resultado = Math.Tanh(angulo);

        else
        {
            //si lo que escribió el usuario está incorrecto
            Console.WriteLine("No contamos con esa operación.");
            return; 
        }

        Console.WriteLine($"Resultado: {operacion}({angulo}) = {resultado}");
    }
}
