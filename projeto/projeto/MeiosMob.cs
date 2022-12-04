using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    /// <summary>
    /// Classe que permite guardar todos os meios de mobilidade criados
    /// </summary>
    internal class MeiosMob
    {
        #region Atributos
        List<MeioMobilidade> listaMeios;
        #endregion

        #region Construtores
        public MeiosMob()
        {
            listaMeios = new List<MeioMobilidade>();
        }
        #endregion

        #region Propriedades
                            // É assim??
        public List <MeioMobilidade> ListaMeios
        {
            get { return listaMeios; }
            set { listaMeios = value; }
        }
        #endregion

        #region OutrosMetodos
        /// <summary>
        /// Permite inserir um meio na lista de meios, caso o meio ainda não exista.
        /// </summary>
        /// <param name="mm"></param>
        /// <returns></returns>
        public bool InserirMeio (MeioMobilidade mm)
        {
            if (!listaMeios.Contains(mm))      
            {
                listaMeios.Add(mm);
                return true;
            }
            return false;
        }

        #endregion
    }
}
