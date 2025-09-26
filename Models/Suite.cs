using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel.Models
{
    public class Suite
    {
        private string _tipoSuite = string.Empty;
        private int _capacidade;
        private decimal _valorDiaria;

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite 
        { 
            get => _tipoSuite; 
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tipo da suíte não pode ser vazio ou nulo.");
                _tipoSuite = value.Trim();
            }
        }

        public int Capacidade 
        { 
            get => _capacidade; 
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Capacidade deve ser maior que zero.");
                _capacidade = value;
            }
        }

        public decimal ValorDiaria 
        { 
            get => _valorDiaria; 
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Valor da diária não pode ser negativo.");
                _valorDiaria = value;
            }
        }
    }
}