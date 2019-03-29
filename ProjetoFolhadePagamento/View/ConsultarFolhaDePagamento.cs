using ProjetoFolhadePagamento.Model;
using ProjetoFolhadePagamento.DAL;
using ProjetoFolhadePagamento.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFolhadePagamento.View
{
    class ConsultarFolhaDePagamento
    {
        public static void Renderizar()
        {
            Funcionario f = new Funcionario();
            FolhaDePagamento fp = new FolhaDePagamento();
            Console.WriteLine("Digite o cpf do funcionario");
            f.cpf = Console.ReadLine();
            f = FuncionarioDAO.BuscarFuncionarioCpf(f);
            if (f != null)
            {
              
                fp.Funcionario = f;
                Console.WriteLine("Digite o mes e o ano");
                fp.MesAno = Convert.ToDateTime(Console.ReadLine());
                fp = FolhaPagamentoDAO.BuscarFolhaPorFuncionarioData(fp);
                Calculos cl = new Calculos();
                if (fp != null)
            
                {
                    
                    Calculos.Calcular(fp);
                }
                else
                {
                    Console.WriteLine("Mes e ano não encontrado");
                }

            }
            else
            {
                Console.WriteLine("CPF NÃO ENCONTRADO");
            }
        }

              public static void Renderizar2()
        {
            Funcionario f = new Funcionario();
            FolhaDePagamento fp = new FolhaDePagamento();
                fp.Funcionario = f;
                Console.WriteLine("Digite o mes e o ano");
                fp.MesAno = Convert.ToDateTime(Console.ReadLine());
                fp = FolhaPagamentoDAO.BuscarFolhaPorFuncionarioData(fp);
                if (fp != null)
                {
                    Console.WriteLine("oi");
                }
                else
                {
                    Console.WriteLine("Mes e ano não encontrado");
                }

            }
          
        }





    }
        



