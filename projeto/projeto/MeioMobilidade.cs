/**
 * @author: Adriana Gomes a23151 | Joana Pereira a23153
 * @email: a23151@alunos.ipca.pt | a23153@alunos.ipca.pt
 * @ date: 04/12/2022
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
    /// Classe que define as caracteristicas de cada meio de mobilidade
    /// </summary>

    internal class MeioMobilidade
    {
        #region Atributos
        int idMeio;
        Modelo modelo;
      //  bool disponibilidade; 
        #endregion

        #region Construtores
        public MeioMobilidade(int idMeio, Modelo modelo)
        {
            this.idMeio = idMeio;
            this.modelo = modelo;
        }
        #endregion

        #region Propriedades

        public int IdMeio
        {
            get { return idMeio; }
            set { idMeio = value; }
        }

        public Modelo Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        //public bool Disponibilidade
        //{
        //    get { return disponibilidade; }
        //    set { disponibilidade = value; }
        //}
        #endregion

        #region OutrosMetodos
        /// <summary>
        /// Reescrita da função Equals. Dois meios de mobilidade são iguais se o ID é igual.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (!(obj is MeioMobilidade)) return false;

            MeioMobilidade m = obj as MeioMobilidade;
            return (this.IdMeio == m.IdMeio);
        }

        /// <summary>
        /// Redefinição do operador == para Meio de Mobilidade
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator ==(MeioMobilidade m1, MeioMobilidade m2)
        {
            return (m1.Equals(m2));

        }

        /// <summary>
        /// Redefinição do operador != para Meio de Mobilidade
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator !=(MeioMobilidade m1, MeioMobilidade m2)
        {
            return (!(m1==m2));
        }

        #endregion
    }
}