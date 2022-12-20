/**
 * @author: Adriana Gomes a23151 | Joana Pereira a23153
 * @email: a23151@alunos.ipca.pt | a23153@alunos.ipca.pt
 * @ date: 29/11/2022
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    [Serializable]
    /// <summary>
    /// Classe Tecnico de SAS, também são utilizadores. Podem consultar os pedidos realizados por todos os utilizadores
    /// </summary>
    internal class TecnicoSAS : Utilizador
    {
        #region Atributos
        string cargo;
        #endregion

        #region Construtores
        public TecnicoSAS(string cargo, int numero, string nome) : base (numero, nome)
        {
            this.cargo= cargo;
        }
        #endregion

        #region Propriedades
        public string Cargo
        {
            get { return cargo; }
            set { this.cargo = value; }
        }
        #endregion

        #region OutrosMetodos

        //public override void ConsultaPedidos(Pedidos listaP)
        //{
        //    foreach (Pedido p in listaP.ListaPedidos)
        //    {
        //        {
        //            Console.WriteLine(p);
        //        }
        //    }
        //}

        #endregion
    }
}
