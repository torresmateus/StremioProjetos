using StremioProjetos.BLL;
using StremioProjetos.MODEL;

var projetos = new List<Projeto>();
projetos = ProjectRepository.GetAll();

foreach(var projeto in projetos)
{
    Console.WriteLine("*****************\nNome Do Projeto: " + projeto.Nome + "\nGerente do Projeto: " + projeto.Gerente);
}