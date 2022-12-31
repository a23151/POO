using BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    /// <summary>
    /// Classe que permite guardar todos os pedidos válidos efetuados numa lista.
    /// </summary>
    public class Pedidos
    {
        #region Atributos
        static List<Pedido> listaPedidos;
        #endregion

        #region Construtores
        static Pedidos()
        {
            listaPedidos = new List<Pedido>();
        }
        #endregion

        #region Propriedades
        public List<Pedido> ListaPedidos
        {
            get
            {
                List<Pedido> copiaP = new List<Pedido>(listaPedidos);
                return copiaP;
            }
            set { listaPedidos = value; }
        }
        #endregion

        #region OutrosMetodos
        /// <summary>
        /// Permite inserir um pedido na lista, caso ainda não exista.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserirPedido(Pedido p)
        {
            if (!listaPedidos.Contains(p)) // && ControlaPedido(p) && AvaliaUtilizadorPedido(p))
            {
                listaPedidos.Add(p);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Controla a ocupação dos meios de mobilidade. Verifica se o meio de mobilidade requisitado está disponível nas datas inseridas,
        /// por comparação com as datas de pedidos ativos já existentes na listaPedidos.
        /// </summary>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool ControlaPedido(Pedido p1)
        {
            List<Pedido> listaPedidosMeio = new List<Pedido>();

            foreach (Pedido p in listaPedidos)
            {
                if (p1.Meio.IdMeio == p.Meio.IdMeio && p.EstadoPedido == Estado.ATIVO)
                {
                    listaPedidosMeio.Add(p);
                }
            }

            foreach (Pedido p in listaPedidosMeio)
            {
                if (p1.DataIni >= p.DataIni && p1.DataIni <= p.DataFim)
                {
                    return false;
                }
                if (p1.DataFim >= p.DataIni && p1.DataFim <= p.DataFim)
                {
                    return false;
                }
                if (p1.DataIni < p.DataIni && p1.DataFim > p.DataFim)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Metodo para validar que um utilizador só tem um pedido no mesmo intervalo de tempo.
        /// </summary>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool AvaliaUtilizadorPedido(Pedido p1)
        {
            List<Pedido> listaPedidosUtilizador = listaPedidos.FindAll(p => (p.Utilizador.Equals(p1.Utilizador) && p.EstadoPedido == Estado.ATIVO)); // cria uma lista com os pedidos ativos de um utilizador

            foreach (Pedido p in listaPedidosUtilizador)
            {
                if (p1.DataIni >= p.DataIni && p1.DataIni <= p.DataFim)
                {
                    return false;
                }
                if (p1.DataFim > p.DataIni && p1.DataFim <= p.DataFim)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Permite consultar os seus pedidos de um utilizador
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static List <Pedido> ConsultarPedidos(Utilizador a)
        {
            List<Pedido> PedidosUtilizador = (listaPedidos.Where(p => p.Utilizador.Equals(a))).ToList();   // Explorar LINQ

            return PedidosUtilizador;
        }

        /// <summary>
        /// Função que mostra os pedidos da listaPedidos. Utiliza o ToString reescrito na classe Pedido.
        /// </summary>
        public static void MostrarPedidos()
        {
           listaPedidos.Sort();         //Necessita de ICompare em Pedido

            foreach (Pedido p in listaPedidos)
            {
                {
                    Console.WriteLine(p);
                }
            }

        }


        /// <summary>
        /// Guarda num ficheiro informação dos pedidos.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static bool GuardarFicheiro(string file)
        {
            //string file = @"C:\Temp\poo.bin";

            try
            {
                Stream stream = File.Open(file, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, listaPedidos);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                //Console.WriteLine(e.Message);
                throw e;
            }
        }
        #endregion
    }
}
