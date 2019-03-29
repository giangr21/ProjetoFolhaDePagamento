using ProjetoFolhadePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFolhadePagamento.Utils
{
    class Calculos
    {

        public static void Calcular(fp)
        {

            
            double salBruto = 0;
            double salLiq = 0;
            double imposto = 0;
            double inss = 0;
            double fgts = 0;
            double bonus = (fp.bonus/100);


            salBruto = ((fp.HorasTrabalhadas * fp.ValorHora) + c.bonus);
            bonus = (salBruto * bonus);
            fgts = (salBruto * 0.08);
            salLiq = ((salBruto - imposto) - inss);

            Console.WriteLine($"Salário bruto: " + salBruto);
            Console.WriteLine($"Bonus: " + bonus);
            Console.WriteLine($"FGTS: " + fgts);
            Console.WriteLine($"Salário Liquido: " + salLiq);
        }
    }
}
