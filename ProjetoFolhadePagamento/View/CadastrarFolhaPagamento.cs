using System;
using System.Collections.Generic;
using ProjetoFolhadePagamento.DAL;
using ProjetoFolhadePagamento.Model;

namespace ProjetoFolhadePagamento.View
{
    class CadastrarFolhaPagamento
    {


        public static void Renderizar()
        {


            List<FolhaDePagamento> folhaPagamentos = FolhaPagamentoDAO.RetonarFuncionarios();
            FolhaDePagamento fp = new FolhaDePagamento();
            Funcionario f = new Funcionario();
            Cargo c = new Cargo();
            Console.WriteLine("Digite o CPF do Funcionario:");
            f.cpf = Console.ReadLine();
            f = FuncionarioDAO.BuscarFuncionarioCpf(f);
            if (f != null)
            {
                fp.Funcionario = f;
                Console.WriteLine("Digite o cargo do Funcionario");
                c.nomeCargo = Console.ReadLine();
                c = CargoDAO.BuscarCargoNome(c);
                if (c != null)
                {
                    fp.Cargo = c;
                    Console.WriteLine("Digite o mes e o ano da folha de pagamento");
                    fp.MesAno = Convert.ToDateTime("21/08");
                    Console.WriteLine("Digite o numero de horas trabalhadas");
                    fp.HorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor da hora");
                    fp.ValorHora = Convert.ToDouble(Console.ReadLine());
                    if (FolhaPagamentoDAO.CadastrarFolhaPagamento(fp))
                    {
                        Console.WriteLine("Folha de pagamento cadastrada com sucesso");
                    }else
                    {
                        Console.WriteLine("Folha de pagamento ja cadastrada");
                    }
                }
                else
                {
                    Console.WriteLine("CPF do funcionario invalido");
                }


            }
        }
    }
}
