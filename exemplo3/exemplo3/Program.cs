using System;

public class exercicio3
{
    //exercicio 3
    public static void Main(string[] args)
    {
        int idade = 20;
        bool eCasado = true;

        if (idade < 18)
        {
            Console.WriteLine("É menor de idade");
        }
        else if (idade >= 18 && idade < 65)
        {
            if (eCasado)
            {
                Console.WriteLine("É casado");
            }
            else if (!eCasado)
            {
                Console.WriteLine("É solteiro");
            }
            Console.WriteLine("É adulto");
        }

        else
        {
            Console.WriteLine("È adulto e solteiro");
        }


    }
}