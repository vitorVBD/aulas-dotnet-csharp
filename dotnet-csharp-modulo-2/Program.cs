﻿using dotnet_csharp_modulo_2.Models;
using System.Diagnostics;
using System.Globalization;
using System.Net.Mail;

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