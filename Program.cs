namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();

    }
    static void Menu()
    {

        Console.Clear();
        Console.WriteLine("Programa Calculadora:");

        Console.WriteLine("-------------------------");

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Exponenciação");
        Console.WriteLine("6 - Sair");

        Console.WriteLine("-------------------------");

        Console.WriteLine("Informe a operação:");

        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 5: Exponenciacao(); break;
            case 6: System.Environment.Exit(0); break;
            default: Menu(); break;
        }

    }

    static void Soma()
    {
        Console.WriteLine("Informe primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{v1} mais {v2} é igual a {v1 + v2}.");

        Console.ReadKey();

        Menu();
    }
    static void Subtracao()
    {
        Console.WriteLine("Informe primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{v1} menos {v2} é igual a {v1 - v2}.");

        Console.ReadKey();

        Menu();
    }
    static void Multiplicacao()
    {
        Console.WriteLine("Informe primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{v1} vezes {v2} é igual a {v1 * v2}.");

        Console.ReadKey();

        Menu();
    }
    static void Divisao()
    {
        Console.WriteLine("Informe primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{v1} dividido por {v2} é igual a {v1 / v2}.");

        Console.ReadKey();

        Menu();
    }

    static void Exponenciacao()
    {
        Console.WriteLine("Informe valor base:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a potência:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{v1} elevado a {v2} é igual a {Math.Pow(v1, v2)}.");

        Console.ReadKey();

        Menu();
    }
}
