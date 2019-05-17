using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    class PassaporteSeguroGarantido : PassaporteDecorator
    {
        public PassaporteSeguroGarantido(IPassaporte umPassaporte) : base(umPassaporte)
        {
        }

        public override decimal valorTotal()
        {
            return base.valorTotal() - (base.valorTotal() * 0.02M);
        }


        public override string ToString()
        {
            return base.ToString() + "\n\tPacote com desconto Seguro Garantido";
        }
    }
}
