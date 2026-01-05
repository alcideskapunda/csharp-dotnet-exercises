
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Abrir arquivo | 2 - Criar/Editar arquivo | 0 - Sair ");

    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            Abrir();
            break;
        case 2:
            Editar();
            break;
        default:
            Menu();
            break;
    }
}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual caminho para salvar o arquivo?");
    // var path = Console.ReadLine();
    var path = "/home/anterokapunda/Documents/cursos/C#/csharp-dotnet-exercises/TextEditor/teste.txt";

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.WriteLine("");
    Console.ReadLine();
    Menu();
}

static void Editar()
{
    Console.Clear();
    System.Console.WriteLine("Digite um texto abaixo.!   (ESC - para sair)");
    System.Console.WriteLine("  -------------------------  ");

    string text = "";
    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(text);
}

static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine("Qual caminho para salvar o arquivo?");
    // var path = Console.ReadLine();
    var path = "/home/anterokapunda/Documents/cursos/C#/csharp-dotnet-exercises/TextEditor/teste.txt";

    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    Console.ReadLine();
    Menu();
}