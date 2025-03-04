namespace ConsoleApp1
{
    public class exemplo7
    {
        public static void Main(string[] args)
        {
            int l = 0;
            switch (l)
            {
                case >= 18 and <= 20:
                    Console.WriteLine("Exelente");
                    break;
                case >= 14 and <= 17:
                    Console.WriteLine("Bom");
                    break;
                case >= 10 and <= 13:
                    Console.WriteLine("Suficiente");
                    break;
                case >= 0 and <= 10:
                    Console.WriteLine("Insuficiente");
                    break;
                default:
                    Console.WriteLine("Nota invalida");
                    break;

            }

        }
    }
}

