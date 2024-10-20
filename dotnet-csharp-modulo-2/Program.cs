using dotnet_csharp_modulo_2.Models;
using System.Diagnostics;
using System.Globalization;
using System.Net.Mail;
using Newtonsoft.Json;

Pessoa p1 = new Pessoa(nome: "Vitor", sobrenome: "Bittencourt");
Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();


// formatando valor monetário de acordo com o seu sistema

Console.WriteLine("Formatando valor monetário:");
decimal valorMonetario = 1520.50M;
Console.WriteLine($"{valorMonetario:C}");

// mudando a localização com código - utilizar System.Globalization

Console.WriteLine("Mudando a localização:");
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"{valorMonetario:C}");

// mudando cultura

Console.WriteLine("Mudando a cultura:");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

// formatação personalizada

Console.WriteLine("Formatação personalizada: apenas uma casa decimal");
Console.WriteLine(valorMonetario.ToString("C1")); // C2 = 2 casas, C3 = 3 casas, C4 = 4 casas...

// porcentagem

Console.WriteLine("Escrevendo em porcentagem:");
double porcentagem = .3521;
Console.WriteLine(porcentagem.ToString("P"));

// formatação de digitos

Console.WriteLine("Formatando um número:");
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

// formatando o tipo DateTime

Console.WriteLine("Usando a data e hora atual:");
DateTime data = DateTime.Now;
Console.WriteLine(data);

Console.WriteLine("Formatando a data:");
Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));

Console.WriteLine("Mostrando só a data:");
Console.WriteLine(data.ToShortDateString());

Console.WriteLine("Mostrando só a hora:");
Console.WriteLine(data.ToShortTimeString());

// converter para data

Console.WriteLine("Convertendo para data:");
string dataString = "2024-10-17 14:40";
DateTime data2 = DateTime.Parse(dataString);

Console.WriteLine(data2);

// convertendo com TryParse

Console.WriteLine("Convertendo com TryParse:");
string dataString2 = "2024-10-17 14:40";
DateTime.TryParseExact(dataString2, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data3);
Console.WriteLine(data3);

// validando o retorno

bool sucesso = DateTime.TryParseExact(dataString2, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data4);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data4}");
}
else
{
    Console.WriteLine($"{dataString2} não é uma data válida");
}

// como ler um arquivo

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException error)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {error.Message}");
}
catch (DirectoryNotFoundException error)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Pasta não encontrada {error.Message}");
}
catch (Exception error)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {error.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui");
}

// usando o Throw (olhar Models/ExemploExceção.cs)

new ExemploExcecao().Metodo1();

// filas
Console.WriteLine("Inicio fila");
// criando a fila
Queue<int> fila = new Queue<int>();

// adicionando elementos na fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

// removendo elementos da fila -> sempre vai remover o primeiro elemento, no caso, o 2

Console.WriteLine($"Removendo o elemento {fila.Dequeue()} da fila");

fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("Fim fila");

// pilhas

Console.WriteLine("Inicio pilha");
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o item {pilha.Pop()} da pilha");

pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("Fim pilha");

// dictionary

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RJ", "Rio de Janeiro");
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Removendo BA");
estados.Remove("BA");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Alterando valores das chaves");

estados["SP"] = "São Paulo - valor alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// verificando se existe um valor no dictionary
string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine("Valor existente");
}
else
{
    Console.WriteLine($"Valor não existe, é seguro adicionar a chave: {chave}");
}

// tuplas

Console.WriteLine("Declarando uma tupla para representar um ID, um nome, um sobrenome e uma altura");
(int id, string nome, string sobrenome, decimal altura) tupla = (1, "Vitor", "Bittencourt", 1.78M);
Console.WriteLine($"ID: {tupla.id}");
Console.WriteLine($"Nome: {tupla.nome}");
Console.WriteLine($"Sobrenome: {tupla.sobrenome}");
Console.WriteLine($"Altura: {tupla.altura}");

// outros exemplos de declaração de tuplas
ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Vitor", "Bittencourt", 1.78M);
var maisUmExemplo = Tuple.Create(1, "Vitor", "Bittencourt", 1.78M);

// testando a tupla em um método

LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso1, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso1)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

// usando o desconstrutor

Console.WriteLine("Criando uma nova pessoa:");
Pessoa p3 = new Pessoa("Vitor", "Bittencourt");

Console.WriteLine("Usando o desconstrutor:");
(string nome, string sobrenome) = p1;
Console.WriteLine($"{nome} {sobrenome}");

// if ternário

int numero1 = 6;
bool ehPar = false;

ehPar = numero1 % 2 == 0;
Console.WriteLine($"O número {numero1} é " + (ehPar ? "par" : "impar"));

// serialização de objetos

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Console.WriteLine("Criando uma venda");
Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

// usando o pacote newtonsoft.json
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); // serializando a lista de objetos em json
File.WriteAllText("Arquivos/vendas.json", serializado); // criando um novo arquivo json com os objetos em serializado
Console.WriteLine("Objeto v1 em formato JSON:");
Console.WriteLine(serializado);

// deserialização de objetos

string conteudoArquivo = File.ReadAllText("Arquivos/vendas2.json");
List<Venda2> listaVenda2 = JsonConvert.DeserializeObject<List<Venda2>>(conteudoArquivo);

foreach (Venda2 venda in listaVenda2)
{
    Console.WriteLine($"ID: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}