using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem.Entities
{
    public class Reserva
    {
        public Reserva() { }
        public Reserva(int diasReservados)
        {
            this.DiasReservados = diasReservados;
        }
        public int DiasReservados { get; set; }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Suite suite = new Suite();

            if (hospedes.Count() > suite.Capacidade)
            {
                Hospedes = hospedes;
            } 
            else {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                decimal desconto = (valor / 100) * 10;
                valor -= desconto;
            }
            return valor;
        }
    }
}
