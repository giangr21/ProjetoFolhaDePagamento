using System;
namespace ProjetoFolhadePagamento.Model
{
     class FolhaDePagamento
    {
        public FolhaDePagamento()
        {
            Funcionario = new Funcionario();
            Cargo = new Cargo();

        }


        public Funcionario Funcionario { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime MesAno { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }
    }
}
