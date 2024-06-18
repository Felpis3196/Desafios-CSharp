internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("A soma dos numeros entre 1 e 10");
        int soma = 0;
        for (int i = 0; i < 11; i++)
        {
            soma = soma += i;
        }
        Console.WriteLine($"Soma dos numeros entre 1 e 10 é {soma}");

        Console.WriteLine($"-----------------------------------------------------------");

        decimal Peso = 0;
        Console.WriteLine("Digite seu Peso (Kg)");
        Peso = Convert.ToDecimal(Console.ReadLine());
        decimal Altura = 0;
        Console.WriteLine("Digite sua Altura (Cm)");
        Altura = Convert.ToDecimal(Console.ReadLine());
        decimal IMC = Peso / (Altura * Altura) * 10000;
        //* Coloquei multiplicando por 10.000 apenas para poder entrar na classificaçao da OMS que achei da medida do IMC
        switch (IMC)
        {
            case decimal n when (n < 18.5m):
                Console.WriteLine("Baixo peso");
                break;

            case decimal n when (n >= 18.5m && n <= 24.9m):
                Console.WriteLine("Eutrofia (peso adequado)");
                break;

            case decimal n when (n >= 25.0m && n <= 29.9m):
                Console.WriteLine("Sobrepeso");
                break;

            case decimal n when (n >= 30.0m && n <= 34.9m):
                Console.WriteLine("Obesidade grau 1");
                break;

            case decimal n when (n >= 35.0m && n <= 39.9m):
                Console.WriteLine("Obesidade grau 2");
                break;

            case decimal n when (n >= 40.0m):
                Console.WriteLine("Obesidade extrema");
                break;

            default:
                Console.WriteLine("Valor de IMC inválido");
                break;
        }

        Console.WriteLine($"-----------------------------------------------------------");

        var operacoes = new Dictionary<char, Func<double, double, double>>()
        {
            { '+', (a, b) => a + b },
            { '-', (a, b) => a - b },
            { '*', (a, b) => a * b },
            { '/', (a, b) => a / b }
        };

        Console.WriteLine("Digite o primeiro número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o operador (+, -, *, /):");
        char operador = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Digite o segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (operacoes.ContainsKey(operador))
        {
            var operacao = operacoes[operador];
            double resultado = operacao(num1, num2);

            Console.WriteLine($"Resultado: {num1} {operador} {num2} = {resultado}");
        }
        else
        {
            Console.WriteLine("Operador inválido.");
        }
    }
}