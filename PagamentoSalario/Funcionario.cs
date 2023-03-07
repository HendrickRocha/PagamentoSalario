using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoSalario
{
    internal class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public double ValorHora { get; set; }
        public double HorasTrabalhadas { get; set; }
        public double Salario { get; private set; }

        public void calcularSalario()
        {
            Salario = ValorHora * HorasTrabalhadas;
        }
    }
}
