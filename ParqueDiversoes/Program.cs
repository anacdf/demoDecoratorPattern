using ParqueBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueDiversoesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaParque bll = new FachadaParque();

            List<IPassaporte> passaportes = new List<IPassaporte>();
            passaportes.Add(bll.CriarPassaporte("John Doe", 7, 100, 10, 1, 2017, new PromocoesAtivas[] { }));
            passaportes.Add(bll.CriarPassaporte("John Student", 7, 100, 10, 2, 2017, new PromocoesAtivas[] { PromocoesAtivas.UNIVERITARIO }));
            passaportes.Add(bll.CriarPassaporte("John PagueBem", 7, 100, 10, 3, 2017, new PromocoesAtivas[] { PromocoesAtivas.PAGUEBEM }));
            passaportes.Add(bll.CriarPassaporte("John Student PagueBem", 7, 100, 10, 4, 2017, new PromocoesAtivas[] { PromocoesAtivas.UNIVERITARIO, PromocoesAtivas.PAGUEBEM }));
            passaportes.Add(bll.CriarPassaporte("John PagueBem Student", 7, 100, 10, 5, 2017, new PromocoesAtivas[] { PromocoesAtivas.PAGUEBEM, PromocoesAtivas.UNIVERITARIO }));
            passaportes.Add(bll.CriarPassaporte("John Idoso", 7, 100, 10, 5, 2017, new PromocoesAtivas[] { PromocoesAtivas.IDOSO }));
            passaportes.Add(bll.CriarPassaporte("John Idoso Garantido", 7, 100, 10, 5, 2017, new PromocoesAtivas[] { PromocoesAtivas.IDOSO, PromocoesAtivas.SEGUROGARANTIDO }));
            passaportes.Add(bll.CriarPassaporte("John PagueBem Student Seguro", 7, 100, 10, 5, 2017, new PromocoesAtivas[] { PromocoesAtivas.PAGUEBEM, PromocoesAtivas.UNIVERITARIO, PromocoesAtivas.SEGUROGARANTIDO }));
            passaportes.Add(bll.CriarPassaporte("John Idoso PagueBem Student Garantido", 7, 100, 10, 5, 2017, new PromocoesAtivas[] { PromocoesAtivas.PAGUEBEM, PromocoesAtivas.UNIVERITARIO, PromocoesAtivas.IDOSO, PromocoesAtivas.SEGUROGARANTIDO }));

            foreach (IPassaporte pass in passaportes) {
                Console.WriteLine(pass);
                for (int i = 1; i <= pass.NroDias; i++)
                {
                    Console.WriteLine("\t\tValor do dia {0} ({1}): {2:c}",
                        i,
                        pass.DataInicial.AddDays(i - 1).ToShortDateString(),
                        pass.valorDoDia(i), i);
                }

                Console.WriteLine("\tValor total do passaporte: {0:c}\n", pass.valorTotal());
            }
           
            Console.ReadKey(); 
        }
    }
}
