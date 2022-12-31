using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DL;

namespace BL
{
    public class Class1
    {
        /// <summary>
        /// Metodo para inserir utilizador na lista a partir do método definido na DL.
        /// </summary>
        /// <param name="ut1"></param>
        /// <returns></returns>
        public static bool InsereUtilizador(Utilizador ut1)
        {
            return Utilizadores.InserirUtilizador(ut1);
        }
        /// <summary>
        /// Metodo que chama a função InserirUtilizadorFicheiro - Recebe os atruibutos de um ficheiro de texto, cria o utilizador e adiciona à lista.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool InsereUtilizadorFicheiro(string path)
        {
            return Utilizadores.InserirUtilizadorFicheiro(path);
        }

        /// <summary>
        /// Metodo utilizado para adicionar Meios a uma lista.
        /// </summary>
        /// <param name="m1"></param>
        /// <returns></returns>
        public static bool InsereMeio(MeioMobilidade m1)
        {
            if (m1 == null) return false; //(?)
            return (MeiosMob.InserirMeio(m1));
        }

        /// <summary>
        /// Imprime todos os meios da lista na consola de acordo com o metodo ToSr«tring implementado em MeioMobilidade.
        /// </summary>
        public static void MostraMeiosMobilidade()
        {
            MeiosMob.MostrarMeiosMobilidade();
        } 

        /// <summary>
        /// Metodo que controla a insersão de pedidos na lista de pedidos. 
        /// </summary>
        /// <param name="p1"></param>
        /// <returns></returns>
        public static bool InserePedido(Pedido p1)
        {
            if (Pedidos.AvaliaUtilizadorPedido(p1))
            {
                if (Pedidos.ControlaPedido(p1))
                {
                    return (Pedidos.InserirPedido(p1));
                }
                else
                    Console.WriteLine("O meio - {0} - nao esta disponivel! Tente outras datas.", p1.Meio);
                return false;
            }
            else
            {
                Console.WriteLine("{0}, já tem um pedido nas datas inseridas.", p1.Utilizador.Nome);
                return false;
            }
        }

        /// <summary>
        /// Apresenta os pedidos de um utilizador.
        /// </summary>
        /// <param name="ut"></param>
        public static void ConsultaPedidos(Utilizador ut)
        {
            List < Pedido > Temp = Pedidos.ConsultarPedidos(ut);
            Console.WriteLine("Pedidos de {0}:", ut.Nome);

            foreach (Pedido p in Temp)
            {
                if (p.Utilizador == ut)
                {
                    Console.WriteLine(p);
                }
            }
        }

        /// <summary>
        /// Apresenta todos os pedidos da lista.
        /// </summary>
        public static void MostraTodosPedidos()
        {

            Pedidos.MostrarPedidos();
        }

        /// <summary>
        /// Guarda informação dos pedidos num ficheiro.
        /// </summary>
        /// <returns></returns>
        public static bool GuardaPedidosFicheiro()
        {
            Console.Write("Diretoria para guardar o ficheiro:");
            string path = Console.ReadLine();
            return Pedidos.GuardarFicheiro(path);
        }
    }
}
