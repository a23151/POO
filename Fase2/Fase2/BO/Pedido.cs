using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    /// <summary>
    /// Define as possibilidades para o atributo estadoPedido do Pedido.
    /// </summary>
    public enum Estado
    {
        ATIVO = 1,
        CANCELADO = 2
    }

    [Serializable]
    /// <summary>
    /// Classe que define as características de cada pedido.
    /// </summary>
    public class Pedido : IComparable
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
            set { meio = value; }
        }

        public Utilizador Utilizador
        {
            get { return utilizador; }
            set { utilizador = value; }
        }

        public DateTime DataIni
        {
            get { return dataIni; }
            set
            {
                if (dataIni > DateTime.Now)
                    dataIni = value;
            }
        }

        public DateTime DataFim
        {
            get { return dataFim; }
            set
            {
                if (dataFim > dataIni)
                    dataFim = value;
            }
        }

        public Estado EstadoPedido
        {
            get { return estadoPedido; }
            set { estadoPedido = value; }
        }
        #endregion

        #region OutrosMetodos
        /// <summary>
        /// ToString override. Define a apresentação (escrita) de pedido.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string nova = String.Format("PedidoID: {0}, Utilizador: {1}, DataInicial: {2}, DataFinal: {3}, Valor: {4} euros, Estado: {5}", IdPedido, Utilizador.Numero, DataIni.ToShortDateString(), DataFim.ToShortDateString(), ValorPagamento(), EstadoPedido);
            return nova;
        }

        /// <summary>
        /// Equals override. Método que permite comparar dois pedidos. Os pedidos são considerados iguais se são feitos pelo mesmo utilizador, requerem o mesmo meio e iniciam na mesma data.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Pedido)) return false;

            Pedido pedido = obj as Pedido;

            return (this.Meio == pedido.Meio && (DateTime.Equals(DataIni, pedido.DataIni) && this.Utilizador.Equals(pedido.Utilizador))); // uso do operador ==  definido em MeioMobilidade;
        }

        /// <summary>
        /// Calcula o valor do pedido, de acordo com a duração.
        /// </summary>
        /// <returns></returns>
        public double ValorPagamento()
        {
            TimeSpan t = dataFim.Subtract(dataIni);

            double valorTot = (t.TotalHours * Meio.Modelo.Preco);

            return valorTot;
        }


        /// <summary>
        /// Escrita do método CompareTo - Compara os pedidos a partir do ID.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CompareTo(Pedido p)
        {
            if (this.IdPedido == p.IdPedido) return 0;
            if (this.IdPedido > p.IdPedido) return 1;
            return -1;
        }

        /// <summary>
        /// Definição do método CompareTo para Pedido através do IdPedido.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is Pedido)
            {
                Pedido p = obj as Pedido;

                if (this.IdPedido == p.IdPedido) return 0;
                if (this.IdPedido > p.IdPedido) return 1;
                return -1;
            }
            return -1;
        }

        #endregion
    }
}
