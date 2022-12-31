using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BL;
using BO;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Utilizadores
            Console.Write("Insira a diretoria do ficheiro a importar:");
            string path = Console.ReadLine();
           // path = "C:\\Users\\ASUS\\Desktop\\IPCA\\2ano\\1semestre\\POO\\Projeto\\Fase2\\utilizador.txt";

            try
            {
                BL.Class1.InsereUtilizadorFicheiro(path);
            }
            catch ( IOException e)
            {
                Console.WriteLine("Erro:" + e.Message);
            }

            BO.Utilizador u3 = new BO.Utilizador(3, "Miguel");
            BO.Utilizador u4 = new BO.Utilizador(4, "Pedro");
            Class1.InsereUtilizador(u3);
            Class1.InsereUtilizador(u4);

            Console.WriteLine();
            #endregion


            #region Modelos e Meios
            Modelo m1 = new Modelo(Tipo.BICICLETA);
            Modelo m2 = new Modelo(Tipo.BICIELETRICA);
            Modelo m3 = new Modelo(Tipo.TROTINETEELETRICA);

            MeioMobilidade mm1 = new MeioMobilidade(m1);
            MeioMobilidade mm2 = new MeioMobilidade(m2);
            MeioMobilidade mm3 = new MeioMobilidade(m3);

            Class1.InsereMeio(mm1);
            Class1.InsereMeio(mm2);
            Class1.InsereMeio(mm3);
            
            Class1.MostraMeiosMobilidade();

            Console.WriteLine();
            #endregion


            #region Pedidos
            Pedido p1 = new Pedido(1, mm1, u3, new DateTime(2022, 11, 11), new DateTime(2022, 11, 12)); //Adiciona
            p1.DataIni = new DateTime(2022,11,10); // Não altera

            Pedido p2 = new Pedido(2, mm1, u3, new DateTime(2022, 12, 17), new DateTime(2022, 12, 20)); //Adiciona
            Pedido p3 = new Pedido(3, mm2, u3, new DateTime(2022, 12, 14), new DateTime(2022, 12, 18)); // Não adiciona (utilizador - data)
            Pedido p4 = new Pedido(4, mm1, u4, new DateTime(2022, 12, 15), new DateTime(2022, 12, 20)); //Não adiciona (meio - data)
            Pedido p5 = new Pedido(5, mm3, u4, new DateTime(2022, 12, 5), new DateTime(2022, 12, 8)); //Adiciona

            Class1.InserePedido(p5); //Desordenado
            Class1.InserePedido(p1);
            Class1.InserePedido(p2);
            Class1.InserePedido(p3);
            Class1.InserePedido(p4);
          

            Console.WriteLine();

            Class1.MostraTodosPedidos();

            Console.WriteLine();

            Class1.ConsultaPedidos(u3);

            Console.WriteLine();

            Class1.GuardaPedidosFicheiro();
            #endregion
        }
    }
}
