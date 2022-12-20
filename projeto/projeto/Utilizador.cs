/**
 * @author: Adriana Gomes a23151 | Joana Pereira a23153
 * @email: a23151@alunos.ipca.pt | a23153@alunos.ipca.pt
 * @ date: 29/11/2022
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    [Serializable]
    /// <summary>
    /// Classe que define as caracteristicas do utilizador
    /// Atributos: int numero; string nome
    /// </summary>
    internal class Utilizador
    {
        #region Atributos
        int numero;
        string nome; 
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor da classe Utilizador
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="nome"></param>
        public Utilizador(int numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
        }

        public Utilizador(string dados)
        {
            string[] vect = dados.Split(',');
            Numero = int.Parse(vect[0]);
            Nome = vect[1];
        }

        #endregion

        #region Propriedades
        /// <summary>
        /// 
        /// </summary>
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
            set {if (nome.Length>0) 
                nome = value; }
        }
        #endregion

        #region OutrosMetodos
        /// <summary>
        /// Equals override - Dois utilizadores são iguais se têm o mesmo numero
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (!(obj is Utilizador)) return false;

            Utilizador m = obj as Utilizador;
            return (this.Numero == m.Numero);
        }


        public bool ImportaFicheiro(string file)
        {
            //-->CONTINUAR
        }

        #endregion
    }
}
