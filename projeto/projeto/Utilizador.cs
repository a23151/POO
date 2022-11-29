using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    internal class Utilizador
    {
        #region Atributos
        int numero;
        #endregion

        #region Construtores
        public Utilizador( int numero)
        {
            this.numero = numero;
        }

        #endregion

        #region Propriedades
        public int Numero
        {
            get { return numero; }
            set { if(value > 0) 
                numero = value; }  // Recebe e vai confirmar à BD IPCA se existe; Validar que não insere nºs negativos
        }
        #endregion

        #region OutrosMetodos
        #endregion
    }
}
