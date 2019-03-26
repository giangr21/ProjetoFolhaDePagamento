using ProjetoFolhadePagamento.DAL;
using ProjetoFolhadePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFolhadePagamento.View
{
    class CadastrarCargo
    {
        public static void Renderizar()
        {
            Cargo c = new Cargo();
            Console.WriteLine("Digite o nome do cargo:");
            c.nomeCargo = Console.ReadLine();
            if (CargoDAO.CadastrarCargo(c))
            {
                Console.WriteLine("Digite o valor do bônus:");
                c.bonus = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Cadastrado com sucesso!.");
            }
            else
            {
                Console.WriteLine("Cargo já cadastrado!.");
            }
           


        }

    }
}
