﻿using System;
public class exemplo_Continue
{
    public static void Main(string[] args)
    {
        for (int contador = 0; contador <= 10; contador++)
        {
            if (contador == 5)
            {
                continue;
            }
            Console.WriteLine(contador);
        }


    }
}