using GetSetValidation.Models;
using System.Globalization;

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

Curso cursoDeIngles = new();
cursoDeIngles.NomeCurso = "Ingles";
cursoDeIngles.Alunos = [];

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();