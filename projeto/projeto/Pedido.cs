using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    internal class Pedido
    {
        #region Atributos
        int idPedido;
        MeioMobilidade meio;
        Utilizador utilizador;
        DateTime dataIni;
        DateTime dataFim;
        // estado (pago ou não)  --> para análise posterior
        // double valorPaga
        #endregion

        #region Construtores
        public Pedido(int idPedido, MeioMobilidade meio, Utilizador utilizador, DateTime dataIni, DateTime dataFim)
        {
            this.dataFim = dataIni;
            this.meio = meio;
            this.utilizador = utilizador;
            this.dataIni = dataIni;
            this.dataFim = dataFim;
        }
        #endregion

        #region Propriedades
        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }
        
        public MeioMobilidade Meio
        {
            get { return meio; } 
            set {meio = value; }
        }

        public Utilizador Utilizador
        {
            get { return utilizador; }
            set { utilizador = value; }   
        }

        public DateTime DataIni
        {
            get { return dataIni; }
            set { dataIni = value; }       
        }

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }
        #endregion

        #region OutrosMetodos
        #endregion
    }
}
