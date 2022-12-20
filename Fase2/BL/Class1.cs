using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using DL;

namespace BL
{
    public class Class1
    {
        public static bool InsereMeio(MeioMobilidade m1)
        {
            if (m1 == null) return false; //(?)
            return (MeiosMob.InserirMeio(m1));
        }

        
        public static bool ValidaUtilizadorPedido(Pedido p1)
        {
            return (Pedidos.AvaliaUtilizadorPedido(p1));
        }

        public static bool InserePedido(Pedido p1)
        {
            return (Pedidos.InserirPedido(p1));
        }

    }
}
