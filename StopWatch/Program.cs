// Start(6);
Menu();

static void Menu()
{
    Console.Clear();
    System.Console.WriteLine("Quanto tempo quer que conte?: ");
    System.Console.WriteLine("S - segundos, ex: 10s = 10 segundos | M - minutos, ex: 1m = 1minuto  | 0 - sair");

    string data = Console.ReadLine()!.ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    // int time = int.Parse(data.Substring(0, data.Length - 1));
    int time = int.Parse(data[..^1]);
    Console.WriteLine(type);
    Console.WriteLine(time);

    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;

    if (time == 0)
        Environment.Exit(0);

    PreStart(time * multiplier);
}

static void PreStart(int time)
{
    Console.Clear();
    System.Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    System.Console.WriteLine("Set...");
    Thread.Sleep(1000);
    System.Console.WriteLine("Go...");
    Thread.Sleep(2500);

    Start(time);
}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        System.Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    System.Console.WriteLine("Fim do StopWatch");
    Thread.Sleep(2500);
    Menu();
}