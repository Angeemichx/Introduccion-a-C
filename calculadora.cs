using System;

class Calculadora
{
    static void Main(string[] args)
    {
        #aqui solo estan declarados numeros random, usted los cambia por los
        # del usuario :)))))
        double angulo = 0.5;
        string operacion = "arcsin";

        double resultado = 0;

        if (operacion == "arcsin")
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

        Console.WriteLine($"Operación: {operacion}({angulo}) = {resultado}");
    }
}