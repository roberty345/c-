using System;
public class exemplo2D22
{
    //exemplo2D22
    public static void Main(string[] args)
    {
        int soma = 0;
        for (int i = 1; i < 50; i++)
        {
            if (i % 2 != 0)
            {
                soma = soma + i;
            }
        }
        Console.WriteLine("total é " + soma);
    }
}