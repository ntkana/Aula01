using Aula01.Classes;

double a = 0;
double b = 0;


Console.WriteLine("Informe o valor de A: ");

while (!double.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Valor inválido. Informe o valor de A: ");
}

Console.WriteLine("Informe o valor de B: ");

while (!double.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Valor inválido. Informe o valor de B: ");
}

Console.WriteLine("Qual operação você deseja fazer?: ");
Console.WriteLine("1 - Somar: ");
Console.WriteLine("2 - Subtrair: ");
Console.WriteLine("3 - Multiplicar: ");
Console.WriteLine("4 - Dividir: ");
Console.WriteLine("0 - Sair: ");

string? opcao = Console.ReadLine();

if (opcao == "0")
{
    Console.WriteLine("Saindo...");
}

Calculadora calc = new Calculadora(a, b);

switch (opcao)
{
    case "1":
        Console.WriteLine("A soma dos valores é igual à: " +calc.Somar());
        break;
    case "2":
        Console.WriteLine("A subtração dos valores é igual à: " + calc.Subtrair());
        break;
    case "3":
        Console.WriteLine("A multiplicação dos valores é igual à: " + calc.Multiplicar());
        break;
    case "4":
        Console.WriteLine("A divisão dos valores é igual à: " + calc.Dividir());
        break;
    default:
        Console.WriteLine("Saindo...");
        break;
}    

Console.WriteLine("A soma dos valores é igual à:" + calc.Somar());

Console.ReadKey();