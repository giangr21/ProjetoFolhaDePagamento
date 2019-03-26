using ProjetoFolhadePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFolhadePagamento.DAL
{
    class CargoDAO
    {

        private static List<Cargo> cargos = new List<Cargo>();

     public static Cargo BuscarCargoNome(Cargo c)
        {
            foreach (Cargo nomeCadastrado in cargos)
            {
                if (nomeCadastrado.nomeCargo.Equals(c.nomeCargo))
                {
                    return nomeCadastrado;
                }
            }
                return null;
            }

        public static bool CadastrarCargo(Cargo c)
        {
            if (BuscarCargoNome(c) == null)
            {
                cargos.Add(c);
                return true;


            }

            return false;

        }

        }
        

    }

