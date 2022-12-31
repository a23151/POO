using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    /// <summary>
    /// Classe que define as caracteristicas do utilizador.
    /// </summary>
    public class Utilizador
    {
        #region Atributos
        int numero;
        string nome;
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor da classe Utilizador.
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="nome"></param>
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
            set
            {
                if (nome.Length > 0)
                    nome = value;
            }
        }
        #endregion

        #region OutrosMetodos
        /// <summary>
        /// Equals override - Dois utilizadores são iguais se tem o mesmo numero.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Utilizador)) return false;

            Utilizador m = obj as Utilizador;
            return (this.Numero == m.Numero);
        }
        #endregion
    }
}
