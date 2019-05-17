using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    class PassaporteIdoso : PassaporteDecorator
    {
        public PassaporteIdoso(IPassaporte umPassaporte) : base(umPassaporte) { }

        public override decimal valorDoDia(int nrodia)
        {
            decimal valBase = base.valorDoDia(nrodia);

            if (NroDias < 4 || nrodia < 3)
            {
                return valBase;
            }

            return valBase - (valBase * 0.15M);
        }


        public override string ToString()
        {
            return base.ToString() + "\n\tPacote com desconto de idoso";
        }
    }
}
