using System;
using System.Collections.Generic;
using ProjetoFolhadePagamento.Model;

namespace ProjetoFolhadePagamento.DAL
{
    class FolhaPagamentoDAO
    {
        private static List<FolhaDePagamento> folhaPagamentos = new List<FolhaDePagamento>();

        public static bool CadastrarFolhaPagamento(FolhaDePagamento fp)
        {
            if (BuscarFolhaPorFuncionarioData(fp) == null)
            {
                folhaPagamentos.Add(fp);
                return true;
            }
            return false;
        }
        public static List<FolhaDePagamento> RetonarFuncionarios()
        {
            return folhaPagamentos;
        }


        public static FolhaDePagamento BuscarFolhaPorFuncionarioData(FolhaDePagamento fp)
        {

            foreach (FolhaDePagamento folhaCadastrada in folhaPagamentos)
            {
                if (folhaCadastrada.Funcionario.cpf.Equals(fp.Funcionario.cpf) && folhaCadastrada.MesAno.Month == fp.MesAno.Month && folhaCadastrada.MesAno.Year == fp.MesAno.Year)
                {
                    return folhaCadastrada;
                }

            }
            return null;
        }
    }
}
