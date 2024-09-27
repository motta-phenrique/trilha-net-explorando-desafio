using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Paulo", sobrenome: "Motta");
Pessoa p2 = new(nome: "Junior", sobrenome: "Silva");
Pessoa p3 = new(nome: "Junior", sobrenome: "Silva");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Console.WriteLine(hospedes);

Suite suite = new(tipoSuite: "Premium", capacidade: 4, valorDiaria: 30);

Reserva reserva = new(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");