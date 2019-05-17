using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    abstract class PassaporteDecorator : IPassaporte
    {
        private IPassaporte passDecorado;

        public PassaporteDecorator(IPassaporte umPassaporte)
        {
            passDecorado = umPassaporte;
        }

        public DateTime DataInicial { get { return passDecorado.DataInicial; } }     
        public string NomeCliente { get { return passDecorado.NomeCliente; } }
        public int NroDias { get { return passDecorado.NroDias; } }
        public decimal ValorBasico { get { return passDecorado.ValorBasico; } }

        public virtual decimal valorDoDia(int nrodia) { return passDecorado.valorDoDia(nrodia); }

        public virtual decimal valorTotal()
        {
            decimal valorTotal = 0M;
            for (int d = 1; d <= NroDias; d++)
            {
                valorTotal += this.valorDoDia(d);
            }
            return valorTotal;
        }

        public override string ToString()
        {
            return passDecorado.ToString();
        }
    }
}
