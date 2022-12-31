using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    /// <summary>
    /// Classe que define as caracteristicas de cada meio de mobilidade
    /// </summary>
    public class MeioMobilidade
    {
        #region Atributos

        static int id;
        int idMeio;
        Modelo modelo;

        #endregion

        #region Construtores
        /// <summary>
        /// Contrutor que recebe todos os atributos
        /// </summary>
        /// <param name="idMeio"></param>
        /// <param name="modelo"></param>
        public MeioMobilidade(int idMeio, Modelo modelo)
        {
            this.idMeio = idMeio;
            this.modelo = modelo;
            id++;
        }

        /// <summary>
        /// Usando este construtor o id do meio é atribuido automaticamente. (Polimorfismo)
        /// </summary>
        /// <param name="modelo"></param>
        public MeioMobilidade(Modelo modelo)
        {
            id++;
            idMeio = id;
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
        #endregion

        #region OutrosMetodos

        /// <summary>
        /// ToString override. Define a apresentação (escrita) das caracteristicas do meio de mobilidade.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string nova = String.Format("ID: {0}, Modelo: {1}", IdMeio, Modelo.Descricao);
            return nova;
        }

        /// <summary>
        /// Reescrita da função Equals. Dois meios de mobilidade são iguais se o ID é igual.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is MeioMobilidade)) return false;

            MeioMobilidade m = obj as MeioMobilidade;
            return (this.IdMeio == m.IdMeio);
        }

        /// <summary>
        /// Redefinição do operador == para Meio de Mobilidade
        /// </summary>
        /// <param name="m1">Meio de mobilidade 1</param>
        /// <param name="m2">Meio de mobilidade 2</param>
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
            return (!(m1 == m2));
        }
        #endregion
    }
}
