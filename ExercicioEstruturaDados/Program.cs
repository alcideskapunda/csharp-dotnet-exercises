using System;
using System.Collections.Generic;


int n = int.Parse(Console.ReadLine());

List<string> sugestoes = new List<string>();

for (int i = 0; i < n; i++)
{
    string linha = Console.ReadLine();
    string[] partes = linha.Split(' ');

    string comando = partes[0];
    string sugestao = partes[1];

    if (comando == "ADD")
    {
        if (!sugestoes.Contains(sugestao))
        {
            sugestoes.Add(sugestao);
        }
    }
    else if (comando == "REMOVE")
    {
        sugestoes.Remove(sugestao);
    }
}

if (sugestoes.Count == 0)
{
    Console.WriteLine("VAZIO");
}
else
{
    sugestoes.Sort();
    Console.WriteLine(string.Join(" ", sugestoes));
}


// Desafio 2

// Lê uma linha contendo as tarefas separadas por espaço
string input = Console.ReadLine();

// Converte a entrada em uma lista de tarefas
List<string> tarefas = [.. input.Split(' ')];

// TODO: Separe as tarefas realizadas ("feito") das tarefas pendentes, mantendo a ordem relativa de ambas nas listas.
// Dica: Percorra todas as tarefas e utilize duas listas diferentes.
List<string> tarefasFeitas = [];
List<string> tarefasPorFazer = [];

foreach (var item in tarefas)
{
    string formatoUnico = item.ToUpper();
    if (formatoUnico == "FEITO")
    {
        tarefasFeitas.Add(item);
    }
    else
    {
        tarefasPorFazer.Add(item);
    }
}

Console.WriteLine(tarefasFeitas.Count);
Console.WriteLine(tarefasPorFazer.Count);

// Após separar, coloque primeiro as pendentes e depois todas as "feito"
List<string> resultado = [.. tarefasPorFazer, .. tarefasFeitas];

// Imprime as tarefas reordenadas
Console.WriteLine(string.Join(" ", resultado));


// Versão de resolução do professor.

// class Program
// {
//     static void Main()
//     {
//         // Lê a linha de entrada
//         string entrada = Console.ReadLine();

//         // Divide as tarefas
//         string[] tarefas = entrada.Split(' ');

//         // Listas auxiliares
//         List<string> naoFeito = new List<string>();
//         List<string> feito = new List<string>();

//         // Percorre as tarefas
//         foreach (string tarefa in tarefas)
//         {
//             if (tarefa == "feito")
//             {
//                 feito.Add(tarefa);
//             }
//             else
//             {
//                 naoFeito.Add(tarefa);
//             }
//         }

//         // Junta as listas (feito no final)
//         naoFeito.AddRange(feito);

//         // Exibe o resultado
//         Console.WriteLine(string.Join(" ", naoFeito));
//     }
// }
