namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Informe primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"{v1} + {v2} é igual a {v1+v2}.");
    }
}
