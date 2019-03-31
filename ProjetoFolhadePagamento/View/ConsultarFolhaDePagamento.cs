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
                if (fp != null)
                {

                    Console.WriteLine("Horas trabalhadas: " + fp.HorasTrabalhadas + " Valor hora: " + fp.ValorHora);
                    Console.WriteLine("Salario bruto: " + Calculos.CalcularSalarioBruto(fp.HorasTrabalhadas, fp.ValorHora, fp.Cargo.bonus));
                    Console.WriteLine("Imposto de renda: " + Calculos.CalcularImpostoRenda(fp.HorasTrabalhadas, fp.ValorHora, fp.Cargo.bonus));
                    Console.WriteLine("INSS: " + Calculos.CalcularINSS(fp.HorasTrabalhadas, fp.ValorHora, fp.Cargo.bonus));
                    Console.WriteLine("FGTS: " + Calculos.CalcularFGTS(fp.HorasTrabalhadas, fp.ValorHora, fp.Cargo.bonus));
                    Console.WriteLine("Bonus: " + fp.Cargo.bonus);
                    Console.WriteLine("Salario liquido: " + (Calculos.CalcularSalarioBruto(fp.HorasTrabalhadas, fp.ValorHora, fp.Cargo.bonus) -
                                      Calculos.CalcularImpostoRenda(fp.HorasTrabalhadas, fp.ValorHora, fp.Cargo.bonus) -
                                      Calculos.CalcularINSS(fp.HorasTrabalhadas, fp.ValorHora, fp.Cargo.bonus)));
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
            Console.WriteLine("Digite o cpf do funcionario");
            f.cpf = Console.ReadLine();
            f = FuncionarioDAO.BuscarFuncionarioCpf(f);
            if (f != null)
            {
                foreach (FolhaDePagamento folhaCadastrada in FolhaPagamentoDAO.BuscarFolhaPorCpf(f.cpf))
                {
                    Console.WriteLine("--------------------- \n");
                    Console.WriteLine("Nome do Funcionario: " + folhaCadastrada.Funcionario.nome);
                    Console.WriteLine("Cargo do Funcionario: " + folhaCadastrada.Cargo.nomeCargo);
                    Console.WriteLine("Mes: " + folhaCadastrada.MesAno.Month + "  Ano: " + folhaCadastrada.MesAno.Year);
                    Console.WriteLine("Salário Bruto:  R$: " + Calculos.CalcularSalarioBruto(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus));
                    Console.WriteLine("Imposto de Renda:  R$: " + Calculos.CalcularImpostoRenda(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus));
                    Console.WriteLine("Imposto de Renda:  R$: " + Calculos.CalcularImpostoRenda(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus));
                    Console.WriteLine("INSS: R$: " + Calculos.CalcularINSS(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus));
                    Console.WriteLine("FGTS:  R$: " + Calculos.CalcularFGTS(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus));
                    Console.WriteLine("Bonus: " + folhaCadastrada.Cargo.bonus);
                    Console.WriteLine("Salario Líquido: R$: " + (Calculos.CalcularSalarioBruto(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus) -
                                          Calculos.CalcularImpostoRenda(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus) -
                                          Calculos.CalcularINSS(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus)));

                }
            }
            else
            {
                Console.WriteLine("Cpf nao encontrado");
            }

        }
        public static void Renderizar3()
        {
            Funcionario f = new Funcionario();
            FolhaDePagamento fp = new FolhaDePagamento();
            Console.WriteLine(" -- Folhas de Pagamento Cadastradas --\n");
            Console.WriteLine("Digite o Mes e o ano: ");
            fp.MesAno = Convert.ToDateTime(Console.ReadLine());
            if (fp.MesAno != null)
            {
                foreach (FolhaDePagamento folhaCadastrada in FolhaPagamentoDAO.BuscarFolhaPorMesAno(Convert.ToString(fp.MesAno.Month), Convert.ToString(fp.MesAno.Year)))
                {
                    Console.WriteLine("--------------------- \n");
                    Console.WriteLine("Nome do Funcionario: " + folhaCadastrada.Funcionario.nome);
                    Console.WriteLine("Cargo do Funcionario: " + folhaCadastrada.Cargo.nomeCargo);
                    Console.WriteLine("Mes: " + folhaCadastrada.MesAno.Month + "  Ano: " + folhaCadastrada.MesAno.Year);
                    Console.WriteLine("Salário Bruto:  R$: " + Calculos.CalcularSalarioBruto(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus));
                    Console.WriteLine("Imposto de Renda:  R$: " + Calculos.CalcularImpostoRenda(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus));
                    Console.WriteLine("INSS: R$: " + Calculos.CalcularINSS(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus));
                    Console.WriteLine("FGTS:  R$: " + Calculos.CalcularFGTS(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus));
                    Console.WriteLine("Bonus: " + folhaCadastrada.Cargo.bonus);
                    Console.WriteLine("Salario Líquido: R$: " + (Calculos.CalcularSalarioBruto(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus) -
                                          Calculos.CalcularImpostoRenda(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus) -
                                          Calculos.CalcularINSS(folhaCadastrada.HorasTrabalhadas, folhaCadastrada.ValorHora, folhaCadastrada.Cargo.bonus)));
                }
            }
        }

    }
}




