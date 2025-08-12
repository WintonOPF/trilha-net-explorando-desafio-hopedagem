using Hospedagem.Entities;

List<Pessoa> hospedes = new List<Pessoa>();

hospedes.Add(new Pessoa("João", "Silva"));
hospedes.Add(new Pessoa("Maria", "Oliveira"));
hospedes.Add(new Pessoa("Ana", "Souza"));

Suite suite = new("Luxo", 3, 200.00m);

Reserva reserva = new(5);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria():C}");

