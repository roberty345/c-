using System;

public class Exercicio_20
{
    public static void Main(string[] args)
    {
        //Converter um double para um int
        double numeroDecimal = 10.75;
        int decimalToInt = Convert.ToInt32(numeroDecimal);

        Console.WriteLine("Decimal:" + numeroDecimal + " To Integer Convert:  " + decimalToInt);

        // Converte um Double para int  
            long numeroMuitoLong = 100000000;
            //int longToIntConvert = Convert.ToInt32(numeroMuitoLong);
            int longToIntCasting = (int)numeroMuitoLong;

            //Console.WriteLine("Long: " + numeroMuitoLong + "To Integer Convert: " + LongToIntConvert);

            Console.WriteLine("Long: " + numeroMuitoLong + "To Integer Convert: " + longToIntCasting);

        //Coverte um char para um ASCII
        char letra = 'B' ;
        int numeroASCIICasting = (int)letra;
        int numeroASCIIConvert = Convert.ToInt32(letra);

        Console.WriteLine("Character:" + letra + "To Int ASCII Covert: " + numeroASCIICasting);
        Console.WriteLine("Character:" + letra + "To Int ASCII Covert: " + numeroASCIIConvert);

        //Converte um int para byte
        int numeroInt = 923;
        byte numeroByteCasting = (byte)numeroInt;
       // byte numeroByteConvert = Convert.ToByte(numeroInt);


        Console.WriteLine("Integer:" + numeroInt + "To Byte Casting: " + numeroByteCasting);
        //Console.WriteLine("Integer:" + numeroInt + "To Byte Convert: " + numeroByteConvert);

        //Converte um double para um float
        double numeroDouble = 1234.56789013426;
        float numeroFloatCasting = (float)numeroDouble;
        float numeroFloatConvert = Convert.ToSingle(numeroDouble);

        Console.WriteLine("Double:"+ numeroDouble + "To Float Casting: " + numeroFloatCasting);
        Console.WriteLine("Double:" + numeroDouble + "To Float Convert: " + numeroFloatConvert);









    }





}
 













