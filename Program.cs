
using HospedagemHotel.Models;

Pessoa p1 = new Pessoa("Joãozinho");
Pessoa p2 = new Pessoa("Fulano");
Pessoa p3 = new Pessoa("Ciclano");

List<Pessoa> pessoaList = new List<Pessoa>();

pessoaList.Add(p1);
pessoaList.Add(p2);
pessoaList.Add(p3);

Suite SPremium = new Suite("Premium", 5, 150.0M);
Suite SBasica = new Suite("Basica", 5, 150.0M);


Console.WriteLine("Sitema de cadastramento do Hotel Pallas");

Reserva reserva = new Reserva(10);
reserva.CadastrarSuite(SPremium);
reserva.CadastrarSuite(SBasica);
reserva.CadastrarHospedes(pessoaList);

Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");