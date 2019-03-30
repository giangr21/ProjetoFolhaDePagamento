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
        public static double CalcularSalarioBruto(int horas, double precohora, double bonus)
        {
            return Convert.ToDouble((horas) * precohora) + bonus;
        }

        public static double CalcularImpostoRenda(int horas, double precohora, double bonus)
        {
            double x = 0;
            x = Convert.ToDouble((horas) * precohora) + bonus;
            if (x <= 1903.98)
            {
                return 0;
            }
            if (x >= (1903.98) && x <= (2826.65))
            {
                return x * 0.075;
            }
            if (x >= (2826.65) && x <= (3751.05))
            {
                return x * 0.15;
            }
            if (x >= (3751.05) && x <= (4664.68))
            {
                return x * 0.225;
            }
            if (x > (4664.68))
            {
                return x * 0.275;
            }

            return 0;
        }

        public static double CalcularINSS(int horas, double precohora, double bonus)
        {
            double x = 0;
            x = Convert.ToDouble((horas) * precohora) + bonus;
            if (x <= 1693.72)
            {
                return x * 0.08;
            }
            if (x >= 1693.72 && x <= 2822.90)
            {
                return x * 0.09;
            }
            if (x >= 2822.90 && x <= 5645.80)
            {
                return x * 0.11;
            }
            if (x > 5645.80)
            {
                return 621.03;
            }

            return 0;
        }

        public static double CalcularFGTS(int horas, double precohora, double bonus)
        {
            double x = 0;
            x = Convert.ToDouble((horas) * precohora) + bonus;
            return x * 0.08;
        }

    }   
}
