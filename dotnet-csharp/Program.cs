using System.Diagnostics.Contracts;
using dotnet_csharp.Common.Models;

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

//laço de repetição for
int numero = 3;
for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
}

//laço de repetição while
int numero = 2;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
    contador++;
}

//laço de repetição do-while
int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0);

Console.WriteLine($"Total da soma dos números = {soma}");

//menu interativo
string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

// arrays

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

// alterando tamanho de um array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// copiando um array para outro
int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

Console.WriteLine("percorrendo o array com for");

for(int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição número {i} - {arrayInteiros[i]}");
}

Console.WriteLine("percorrendo o array com foreach");

int contadorForEach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição número {contadorForEach} - {valor}");
    contadorForEach++;
}

List<string> listaString = new List<string>();

listaString.Add("RJ");
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição número {contador} - {listaString[contador]}");
}

Console.WriteLine("usando foreach");
int posicao = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição número {posicao} - {item}");
    posicao++;
}