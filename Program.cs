// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe a opção desejada:");
Console.WriteLine("1- Inserir novo aluno");
Console.WriteLine("2- Listar alunos");
Console.WriteLine("3- Calcular a Média Geral");
Console.WriteLine("x- Sair");
Console.WriteLine();

static void Main(string[] ards)
{
string opcaoUsuario = Console.ReadLine();

while (opcaoUsuario.ToUpper() != "X")
{
    switch(opcaoUsuario)
    {
        case "1":
            //TODO: adicionar aluno1
            break;
        case "2":
            //TODO: listar aluno
            break;
        case "3":
            //TODO: calcular media geral
            break;
        default:
        throw new ArgumentOutOfRangeException();
    }

opcaoUsuario = ObterOpcaoUsusario();

}


}

private static string ObterOpcaoUsusario()
{
Console.WriteLine("Informe a opção desejada:");
Console.WriteLine("1- Inserir novo aluno");
Console.WriteLine("2- Listar alunos");
Console.WriteLine("3- Calcular a Média Geral");
Console.WriteLine("x- Sair");
Console.WriteLine();

string opcaoUsuario = Console.ReadLine();
Console.WriteLine();
return opcaoUsuario;

}
