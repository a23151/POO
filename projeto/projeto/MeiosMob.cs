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
        public List <MeioMobilidade> ListaMeios
        {
            get {
                List<MeioMobilidade> copiaM = new List<MeioMobilidade>(listaMeios);
                return copiaM; 
            }
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
