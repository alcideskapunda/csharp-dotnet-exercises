using GetSetValidation.Models;

Pessoa p1 = new("Mingous", "Kapunda");
// p1.Idade = 20;
// p1.Apresentar();

Pessoa p2 = new("Ântero", "O Vazio");

Curso cursoDeIngles = new();
cursoDeIngles.NomeCurso = "Ingles";
cursoDeIngles.Alunos = [];

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();