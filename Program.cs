using dotnet_csharp.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Vitor";
pessoa1.Idade = 26;

pessoa1.Apresentar();

DateTime data = DateTime.Now;
Console.WriteLine(data);

//cast - casting
//int a = int.Parse("5");
int a = Convert.ToInt32("5");
int inteiro = 5;
string b = inteiro.ToString();

//casting implicito
int c = 5;
double d = c;

//convertendo de forma segura
string numeroString = "15";
int.TryParse(numeroString, out int numeroInteiro);
Console.WriteLine(numeroInteiro);

//condicionais

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe não temos a quantidade desejada em estoque");
}

//switch case
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Consoante");
        break;
}

Calculadora calculadora = new Calculadora();

calculadora.Somar(2, 2);
calculadora.Subtrair(4, 2);
calculadora.Multiplicar(2, 5);
calculadora.Dividir(6, 2);
calculadora.Potencia(3, 3);
calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);
calculadora.RaizQuadrada(144);