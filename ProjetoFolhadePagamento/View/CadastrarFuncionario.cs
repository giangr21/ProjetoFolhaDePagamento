using ProjetoFolhadePagamento.DAL;
using ProjetoFolhadePagamento.Model;
using ProjetoFolhadePagamento.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFolhadePagamento.View
{
    class CadastrarFuncionario
    {
        public static void Renderizar()
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("Digite o nome do Funcionario:");
            f.nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do Funcionario:");
            f.cpf = Console.ReadLine();
            if (Validar.ValidarCpf(f.cpf))
            {
                Console.WriteLine("Digite a data de nascimento do Funcionario: (dd/mm/yyyy)");
                f.DataNasc = DateTime.Parse(Console.ReadLine());

                if (FuncionarioDAO.CadastrarFuncionario(f))
                {

                    Console.WriteLine("Funcionário cadastrado com sucesso!.");

                }
                else
                {
                    Console.WriteLine("Funcionário já existe na base.");

                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }
    }
}
