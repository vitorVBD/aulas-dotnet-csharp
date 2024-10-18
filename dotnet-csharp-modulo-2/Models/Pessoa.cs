using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_csharp_modulo_2.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("o nome não pode ser vazio");
                }

                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();



        private int _idade;
        public int Idade 
        {
            get
            {
                return _idade;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("a idade não pode ser negativa");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}