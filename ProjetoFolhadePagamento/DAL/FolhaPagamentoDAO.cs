using System;
using System.Collections.Generic;
using System.Linq;
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

        public static List<FolhaDePagamento> BuscarFolhaPorCpf(string cpf)
        {
            List<FolhaDePagamento> auxFolha = new List<FolhaDePagamento>();
            foreach (FolhaDePagamento folhacadastr in folhaPagamentos)
            {
                if (folhacadastr.Funcionario.cpf.Equals(cpf))
                {
                    auxFolha.Add(folhacadastr);
                }
            }
            return auxFolha.OrderBy(x => x.MesAno).ToList();
        }

        public static List<FolhaDePagamento> BuscarFolhaPorMesAno(string mes, string ano)
        {
            List<FolhaDePagamento> auxFolha = new List<FolhaDePagamento>();
            foreach (FolhaDePagamento folhacadastr in folhaPagamentos)
            {
                if (Convert.ToString(folhacadastr.MesAno.Month).Equals(mes) &&
                    Convert.ToString(folhacadastr.MesAno.Year).Equals(ano))
                {
                    auxFolha.Add(folhacadastr);
                }
            }
            return auxFolha;
        }
    }
}
