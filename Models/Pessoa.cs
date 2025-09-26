using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel.Models
{
    public class Pessoa
    {
        private string? _nome;
        private string? _sobrenome;

        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string? Nome 
        { 
            get => _nome; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nome não pode ser vazio ou nulo.");
                _nome = value.Trim();
            }
        }

        public string? Sobrenome 
        { 
            get => _sobrenome; 
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _sobrenome = value.Trim();
                else
                    _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}