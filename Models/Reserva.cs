using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel.Models
{
    public class Reserva
    {
        private List<Pessoa> _hospedes = new List<Pessoa>();
        private Suite? _suite;
        private int _diasReservados;

        public List<Pessoa> Hospedes 
        { 
            get => _hospedes; 
            private set => _hospedes = value ?? new List<Pessoa>(); 
        }

        public Suite? Suite 
        { 
            get => _suite; 
            private set => _suite = value; 
        }

        public int DiasReservados 
        { 
            get => _diasReservados; 
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Dias reservados deve ser maior que zero.");
                _diasReservados = value;
            }
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes == null)
                throw new ArgumentNullException(nameof(hospedes), "Lista de hóspedes não pode ser nula.");

            if (Suite == null)
                throw new InvalidOperationException("É necessário cadastrar uma suíte antes de cadastrar os hóspedes.");

            // Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            if (hospedes.Count > Suite.Capacidade)
            {
                // Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new ArgumentException("A capacidade da suíte é menor que o número de hóspedes.");
            }
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            if (suite == null)
                throw new ArgumentNullException(nameof(suite), "Suíte não pode ser nula.");
            
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
                throw new InvalidOperationException("É necessário cadastrar uma suíte para calcular o valor da diária.");

            // Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor -= (valor * 0.10M);
            }

            return valor;
        }
    }
}