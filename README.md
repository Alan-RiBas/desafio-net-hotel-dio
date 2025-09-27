🏨 Sistema de Hospedagem em C#
📖 Descrição

Este projeto é parte do desafio da trilha .NET da DIO e tem como objetivo criar um sistema simples de hospedagem em C#.
O sistema permite gerenciar hóspedes, suítes e reservas, aplicando regras de negócio como cálculo de diárias, quantidade de hóspedes e concessão de descontos.

🎯 Objetivo do Desafio

Implementar as regras de negócio faltantes no código base fornecido, completando os trechos marcados com // TODO.

📌 Regras e Validações

✅ Não deve ser possível realizar uma reserva em uma suíte com capacidade menor que o número de hóspedes.
✅ O método ObterQuantidadeHospedes deve retornar a quantidade total de hóspedes na reserva.
✅ O método CalcularValorDiaria deve retornar o valor total da hospedagem, calculado como:

Valor = Dias Reservados x Valor da Diária


✅ Caso a reserva seja igual ou maior que 10 dias, aplicar 10% de desconto no valor final.

🛠️ Estrutura do Projeto

O sistema é composto por três classes principais:

Pessoa → representa o hóspede.

Suite → representa a suíte escolhida (capacidade e valor da diária).

Reserva → relaciona hóspedes e suíte, aplicando as regras de negócio.

🧑‍💻 Exemplo de Uso
// Criando hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
hospedes.Add(new Pessoa("Ana"));
hospedes.Add(new Pessoa("Carlos"));

// Criando a suíte
Suite suite = new Suite("Premium", 2, 100);

// Criando reserva
Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibindo informações
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");

📝 Saída esperada:
Hóspedes: 2
Valor da diária: 1080


(Com desconto aplicado, já que a reserva foi de 12 dias)

🚀 Tecnologias Utilizadas

C#

.NET 6+

Programação Orientada a Objetos (POO)

📦 Como Executar o Projeto

Clone o repositório:

git clone [https://github.com/Alan-RiBas/desafio-net-hotel-dio](https://github.com/Alan-RiBas/desafio-net-hotel-dio)


Acesse a pasta do projeto:

cd sistema-hospedagem


Execute o projeto com o .NET CLI:

dotnet run

🏆 Desafio DIO

Projeto desenvolvido como parte do módulo Explorando a Linguagem C# da Digital Innovation One
.
