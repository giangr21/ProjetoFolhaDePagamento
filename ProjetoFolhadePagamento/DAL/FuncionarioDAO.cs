using ProjetoFolhadePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFolhadePagamento.DAL
{
    class FuncionarioDAO
    {

        private static List<Funcionario> funcionarios = new List<Funcionario>();

        public static Funcionario BuscarFuncionarioCpf(Funcionario f)
        {
            foreach (Funcionario funcionarioCadastrado in funcionarios)
            {
                if (funcionarioCadastrado.cpf.Equals(f.cpf))
                {
                    return funcionarioCadastrado;
                }
            }
            return null;
        }

        public static bool CadastrarFuncionario(Funcionario f)
        {
            if (BuscarFuncionarioCpf(f) == null)
            {
                funcionarios.Add(f);
                return true;


            }

            return false;

        }

    }


}

