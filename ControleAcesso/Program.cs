using ControleAesso;

Console.WriteLine(" === terminal de acesso smart === ");

IValidavel usuarioTentandoEntrar;

Console.WriteLine("quem esta tentando entrar? 1 gerente / 2 operador");
string escolha = Console.ReadLine();


Console.Write("informe seu nome: ");
string nome = Console.ReadLine();



switch(escolha)
{
    case "1":
       Gerente g = new Gerente(nome);
        g.BoasVindas();
        usuarioTentandoEntrar = g;
        break;

    case "2":
        Operador o = new Operador(nome);
        o.BoasVindas();
        usuarioTentandoEntrar = o;
        break;

    default:
        Console.WriteLine("opcao invalida! o sistema sera encerrado.");
        return;

}

if (usuarioTentandoEntrar.Validar())
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nsucesso acesso liberado bem vindo");
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n[ERRO] acesso negado. credencias invalidas");
}

Console.ResetColor();
Console.WriteLine("\npressione qualquer tecla para sair...");
Console.ReadKey();