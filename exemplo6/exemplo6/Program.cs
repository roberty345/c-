public class exemplo6
{
    public static void Main(string[] args)
    {
        int nota = 75;
        switch (nota)
        {
            case int n when (n >= 90):
                Console.WriteLine("Classificação final = A");
                break;
            case int n1 when (n1 >= 80):
                Console.WriteLine("Classificação final = B");
                break;
            case int n3 when (n3 >= 70):
                Console.WriteLine("Classificação final = C");
                break;
            case int n4 when (n4 >= 60):
                Console.WriteLine("Classificação final = D");
                break;
            default:
                Console.WriteLine("Reprovado F");
                break;
        }
    }
}
