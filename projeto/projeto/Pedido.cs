 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    enum Estado
    {
        ATIVO = 1,
        CANCELADO = 2
    }

    /// <summary>
    /// Classe que define as caracteristicas de cada pedido
    /// </summary>
    internal class Pedido
    {
        #region Atributos
        int idPedido;
        MeioMobilidade meio;
        Utilizador utilizador;
        DateTime dataIni;
        DateTime dataFim;
        Estado estadoPedido;
        #endregion

        #region Construtores
        public Pedido(int idPedido, MeioMobilidade meio, Utilizador utilizador, DateTime dataIni, DateTime dataFim)
        {
            this.idPedido = idPedido;
            this.meio = meio;
            this.utilizador = utilizador;
            this.dataIni = dataIni;
            this.dataFim = dataFim;
            estadoPedido = Estado.ATIVO;
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
            set { 
                if (dataIni > DateTime.Now)
                    dataIni = value; }       
        }

        public DateTime DataFim
        {
            get { return dataFim; }
            set { if(dataFim > dataIni) 
                dataFim = value; }
        }

        public Estado EstadoPedido
        {
            get { return estadoPedido;}
            set { estadoPedido = value;}
        }
        #endregion


        #region OutrosMetodos

        /// <summary>
        /// ToString override. Define a apresentação de pedido.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {            
            string nova = String.Format("Utilizador: {0}, : {1}, DataInicial: {2}, DataFinal: {3}, Valor: {4} euros, Estado: {5}\n", Utilizador.Numero, IdPedido, DataIni.ToShortDateString(), DataFim.ToShortDateString(), ValorPagamento(), EstadoPedido);
            return nova;
        }
        /// <summary>
        /// Equals override. Método que permite comparar dois pedidos. Os pedidos são considerados iguais se são feitos pelo mesmo utilizador, requerem o mesmo meio e iniciam na mesma data.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (!(obj is Pedido)) return false;

            Pedido pedido = obj as Pedido;
            
            return (this.Meio == pedido.Meio && (DateTime.Equals(DataIni, pedido.DataIni) && this.Utilizador.Equals(pedido.Utilizador))); // uso do operador ==  definido em MeioMobilidade;
        }
     

        /// <summary>
        /// Calcula o valor do pedido
        /// </summary>
        /// <returns></returns>
        public double ValorPagamento()
        {
            double valor = Meio.Modelo.Valor();
            TimeSpan t = dataFim.Subtract(dataIni);     

            double valorTot = (t.TotalHours * valor);
            
            return valorTot;
        }

        #endregion
    }
}
