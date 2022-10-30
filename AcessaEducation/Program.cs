using AcessaEducation.EscolasIntegration;
Uni9 uni9 = new Uni9();

Console.WriteLine("====================== Está Aplicação Integra Sistemas de Escolas ======================");
Console.WriteLine("========================================================================================");

Console.WriteLine("=============================== Escolha sua Escola =====================================");
Console.WriteLine("========================================================================================");
Console.WriteLine("1-) Universidade Nove de Julho");
Console.WriteLine("========================================================================================");
int escolaEscolha = int.Parse(Console.ReadLine());
Console.WriteLine("========================================================================================");

switch (escolaEscolha)
{
    case 1:
        await uni9.AcessaUni9();
        break;
}