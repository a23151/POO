using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    /// <summary>
    /// Classe que define as caracteristicas do utilizador
    /// </summary>
    internal class Utilizador
    {
        #region Atributos
        int numero;
        string nome; 
    
        #endregion

        #region Construtores
        public Utilizador(int numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
        }

        #endregion

        #region Propriedades
        public int Numero
        {
            get { return numero; }
            set
            {
                if (value > 0)
                    numero = value;
            } 
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region OutrosMetodos
        public override bool Equals(object? obj)
        {
            if (!(obj is Utilizador)) return false;

            Utilizador m = obj as Utilizador;
            return (this.Numero == m.Numero);
        }

        public virtual void ConsultaPedidos(Pedidos listaP)
        {
            {
                foreach (Pedido p in listaP.ListaPedidos)
                {
                    if (p.Utilizador.Equals(this))
                    {
                        Console.WriteLine(p);
                    }
                }
            }

            #endregion
        }
    }
}
