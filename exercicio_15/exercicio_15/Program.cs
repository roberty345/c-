﻿﻿using System;

public class exercicio_15
{
    public static void Main(string[] args)
    {
        //dados

        bool resultado = ParImpar (10);

        //lógica

        if (resultado == true)
        {
            Console.WriteLine("O número é par");
        }
        else
        {
            Console.WriteLine("O número é impar");
        }
    }
    public static bool ParImpar(int a) 
    {
        return (a % 2 == 0);
    }
}
