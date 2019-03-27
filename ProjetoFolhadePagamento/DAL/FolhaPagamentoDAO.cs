using System;
using System.Collections.Generic;
using ProjetoFolhadePagamento.Model;

namespace ProjetoFolhadePagamento.DAL
{
    class FolhaPagamentoDAO
    {
        private static List<FolhaDePagamento> folhaPagamentos = new List<FolhaDePagamento>();

        public static void CadastrarFolhaPagamento(FolhaDePagamento fp)
        {

            folhaPagamentos.Add(fp);
        }
        public static List<FolhaDePagamento> RetonarFuncionarios()
        {
            return folhaPagamentos;
        }

    }
}
