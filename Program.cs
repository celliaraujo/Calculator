namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Programa Calculadora:");

        Console.WriteLine("----------------------");

        Console.WriteLine("Informe primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a operação:");
        Console.WriteLine("1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão");

        int opcao = int.Parse(Console.ReadLine());

        Operacao(opcao, v1, v2);

    }

    static void Operacao(int opcao, double v1, double v2)
    {
        switch (opcao)
        {
            case 1: Soma(v1, v2); break;
            case 2: Subtracao(v1, v2); break;
            case 3: Multiplicacao(v1, v2); break;
            case 4: Divisao(v1, v2); break;
            default: Console.WriteLine("Opção Inválida! Encerrando a aplicação..."); break;
        }
    }

    static void Soma(double v1, double v2)
    {
        Console.WriteLine($"{v1} mais {v2} é igual a {v1 + v2}.");
    }
    static void Subtracao(double v1, double v2)
    {
        Console.WriteLine($"{v1} menos {v2} é igual a {v1 - v2}.");
    }
    static void Multiplicacao(double v1, double v2)
    {
        Console.WriteLine($"{v1} vezes {v2} é igual a {v1 * v2}.");
    }
    static void Divisao(double v1, double v2)
    {
        Console.WriteLine($"{v1} dividido por {v2} é igual a {v1 / v2}.");
    }
}
