using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    class PassaporteFactory
    {
        public static IPassaporte CriarPassaporte(String umCliente,
                                                  int umNroDias,
                                                  decimal umValorBasico,
                                                  int dia,
                                                  int mes,
                                                  int ano,
                                                  PromocoesAtivas[] descontos)
        {
            IPassaporte novo = new PassaporteBasico(umCliente, umNroDias, umValorBasico, dia, mes, ano);

            foreach (PromocoesAtivas promo in descontos)
            {
                switch (promo)
                {
                    case PromocoesAtivas.PAGUEBEM: novo = new PassaportePagueBem(novo); break;
                    case PromocoesAtivas.UNIVERITARIO: novo = new PassaporteUniversitario(novo); break;
                    case PromocoesAtivas.IDOSO: novo = new PassaporteIdoso(novo); break;
                    case PromocoesAtivas.SEGUROGARANTIDO: novo = new PassaporteSeguroGarantido(novo); break;
                }
            }

            return novo;
        }
    }
}
