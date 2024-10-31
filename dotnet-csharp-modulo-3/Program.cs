using dotnet_csharp_modulo_3.Models;

Pessoa p1 = new Pessoa("Vitor");
p1.Idade = 26;

p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(250);
c1.ExibirSaldo();
c1.Sacar(1000);
c1.ExibirSaldo();

// criando um novo Aluno herdando propriedades de Pessoa
Aluno a1 = new Aluno("Vitor");
a1.Idade = 26;
a1.Nota = 10;

// criando um novo Professor herdando propriedades de Pessoa
Professor pr1 = new Professor("Eduardo");
pr1.Idade = 30;
pr1.Salario = 5000.00M;


a1.Apresentar();
pr1.Apresentar();

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();


Calculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Somar(5, 5));