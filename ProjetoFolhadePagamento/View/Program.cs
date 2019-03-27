using ProjetoFolhadePagamento.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFolhadePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;


            do

            {

                Console.Clear();
                Console.WriteLine("\n ----------------------MENU--------------------- \n");
                Console.WriteLine("1 - CADASTRAR CARGO");
                Console.WriteLine("2 - CADASTRAR FUNCIONARIO");
                Console.WriteLine("3 - CADASTRAR FOLHA DE PAGAMENTO");
                Console.WriteLine("4 - CONSULTAR FOLHA DE PAGAMENTO");
                Console.WriteLine("5 - CONSULTAR HISTÓRICO DE FOLHA DE PAGAMENTO DO FUNCIONARIO");
                Console.WriteLine("6 - CONSULTAR HISTÓRICO DE FOLHA DE PAGAMENTO DO MÊS");
                Console.WriteLine("0 - SAIR");
                opcao = Convert.ToInt32(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        CadastrarCargo.Renderizar();
                        break;

                    case 2:
                        CadastrarFuncionario.Renderizar();
                        break;
                    case 3:
                        CadastrarFolhaPagamento.Renderizar();
                        break;

                    default:
                        Console.WriteLine("Digite uma opcao valida");
                        break;
                }

                Console.WriteLine("Aperte uma tecla para continuar...");
                Console.ReadKey();

            }
            while (opcao != 0);
        }
    }
}
