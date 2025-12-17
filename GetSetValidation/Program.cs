using GetSetValidation.Models;
using System.Globalization;

// colecoes de dados dicionário / Dictionary - tipo um "array" de, chave e valor. as chaves/key devem ser unicas senão gera uma excecao
Dictionary<string, string> estados = [];

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("C2", "Calemba 2");
estados.Add("MG", "Minas Gerais");

// Acessar valor issolado
Console.WriteLine(estados["C2"]);
Console.WriteLine();

foreach (var item in estados)
{
    Console.WriteLine(item);
    Console.WriteLine($"Chaves: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("------------------------");
// Para remover um el é só usar a chave como referencia.
estados.Remove("MG");
// Apenas os values podem ser alterados.
estados["SP"] = "São Paulo - Valor alterado";

foreach (var item in estados)
{
    Console.WriteLine(item);
    Console.WriteLine($"Chaves: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine();

string chave = "BA";
Console.WriteLine("Verificar se o elemento existe " + chave);

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor já existe no dictionary {chave}");
}

Console.WriteLine();

// colecoes de dados pilha / stack
Stack<int> pilha = new();
//metodo para add el no final/topo da pilha. a stack trabalha com a ordem de adição e remoção LIFO
pilha.Push(2);
pilha.Push(4);
pilha.Push(8);
pilha.Push(12);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o ultimo elemento (el do topo) da pilha: {pilha.Pop()}");
pilha.Push(20);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine();

// colecoes de dados fila / queue
Queue<int> fila = new();
//metodo para add el no final da fila. a queue trabalham com a ordem de adição e remoção FIFO
fila.Enqueue(1);
fila.Enqueue(3);
fila.Enqueue(9);
fila.Enqueue(11);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o primeiro elemento da fila: {fila.Dequeue()}");

foreach (var item in fila)
{
    Console.WriteLine(item);
}

// Tratamento de excessoes com try-catch
try
{
    string[] linhas = File.ReadAllLines("Arquivos/leitura.txt");

    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{

    Console.WriteLine($"Erro na leitura do arq. Arquivo não encontrado: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{

    Console.WriteLine($"Erro na leitura do arq. Pasta não encontrada: {ex.Message}");
}
catch (System.Exception ex)
{

    Console.WriteLine($"Erro na leitura do aqr. erro generico: {ex.Message}");
}

DateTime data = DateTime.Now;

Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine();

// tryParseExact - para formatar datas.

// Formatar Números - moeda/dinheiro, data, hora
CultureInfo.DefaultThreadCurrentCulture = new("pt-BR");

var cash = 2500.90M;
var cashDoll = 2500.90M;
var porcentagem = .3421;
var numAleatorio = 123456;

Console.WriteLine($"{cash:C}");
Console.WriteLine(cashDoll.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(porcentagem.ToString("P"));
Console.WriteLine(numAleatorio.ToString("##-##-##"));


Pessoa p1 = new("Mingous", "Kapunda");
// p1.Idade = 20;
// p1.Apresentar();

Pessoa p2 = new("Ântero", "O Vazio");

Curso cursoDeIngles = new()
{
    NomeCurso = "Ingles",
    Alunos = []
};

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();