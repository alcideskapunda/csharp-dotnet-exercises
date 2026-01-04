
Menu();

Console.WriteLine("----------------");

Console.ReadKey();
Menu();

static void Menu()
{
    Console.WriteLine("Operações Matematicas");
    Console.WriteLine("1 - Soma | 2 - Sub | 3 - Mult | 4 - Div | 5 - Sair");

    string? option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Soma();
            break;
        case "2":
            Sub();
            break;
        case "3":
            Mult();
            break;
        case "4":
            Div();
            break;
        case "5":
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção invalida!");
            Menu();
            break;
    }
}


static Valores Values()
{
    Console.WriteLine("Primeiro valor:");
    decimal v1 = decimal.Parse(Console.ReadLine()!);

    Console.WriteLine("Segundo valor:");
    decimal v2 = decimal.Parse(Console.ReadLine()!);

    return new Valores(v1, v2);
}

static void Soma()
{
    var values = Values();
    var result = values.V1 + values.V2;

    Console.WriteLine($"{values.V1} + {values.V2} = {result}");
}

static void Sub()
{
    var values = Values();
    var result = values.V1 - values.V2;

    Console.WriteLine($"{values.V1} - {values.V2} = {result}");
}

static void Mult()
{
    var values = Values();
    var result = values.V1 * values.V2;

    Console.WriteLine($"{values.V1} x {values.V2} = {result}");
}

static void Div()
{
    var values = Values();
    var result = values.V1 / values.V2;

    Console.WriteLine($"{values.V1} / {values.V2} = {result}");
}


public record Valores(decimal V1, decimal V2);