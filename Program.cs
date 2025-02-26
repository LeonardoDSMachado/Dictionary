using _06Dictionary;

Aluno alu1 = new Aluno();
alu1.Name = "Maria";
alu1.Nota = 7;

Aluno alu2 = new Aluno();
alu2.Name = "Eric";
alu2.Nota = 8;

Aluno alu3 = new Aluno();
alu3.Name = "Ana";
alu3.Nota = 9;

Aluno alu4 = new Aluno();
alu4.Name = "Alex";
alu4.Nota = 6;

Aluno alu5 = new Aluno();
alu5.Name = "Diná";
alu5.Nota = 5;

Dictionary<int,Aluno> alunos = new Dictionary<int,Aluno>();

alunos.Add(1, alu1);
alunos.Add(2, alu2);
alunos.Add(3, alu3);
alunos.Add(4, alu4);
alunos.Add(5, alu5);

Console.WriteLine("Exibindo os valores do Dictionary...\n");
foreach (var i in alunos.Values)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nLocalizando um aluno...\n");
Console.WriteLine(alunos[4]);

Console.WriteLine("\nAtualizando a Nota do aluno acima...\n");
alunos[4].Nota = 1;
Console.WriteLine(alunos[4]);

Console.WriteLine("\nRemovendo um aluno da coleção...\n");
alunos.Remove(4);

foreach (var i in alunos.Values)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nOrdenando por ordem alfabetica...\n");
var alunosOrdenados = alunos.Values.OrderBy(a => a.Name);

foreach (var aluno in alunosOrdenados)
{
    Console.WriteLine(aluno);
}

Console.WriteLine("\nLimpando minha lista...\n");
alunos.Clear();

foreach (var i in alunos.Values)
{
    Console.WriteLine(i);
}

Console.ReadKey();