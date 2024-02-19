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

        Console.WriteLine("----------------------");

        Console.WriteLine("Informe a operação:");
        Console.WriteLine("1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão");

        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
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
    }
    static void Subtracao()
    {
        Console.WriteLine("Informe primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{v1} menos {v2} é igual a {v1 - v2}.");
    }
    static void Multiplicacao()
    {
        Console.WriteLine("Informe primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{v1} vezes {v2} é igual a {v1 * v2}.");
    }
    static void Divisao()
    {
        Console.WriteLine("Informe primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{v1} dividido por {v2} é igual a {v1 / v2}.");
    }
}
