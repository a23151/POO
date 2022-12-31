using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;

namespace DL
{
    /// <summary>
    /// Classe que permite guardar os meios de mobilidade criados numa lista.
    /// </summary>
    public class MeiosMob
    {
        #region Atributos
        static List<MeioMobilidade> listaMeios;
        #endregion

        #region Construtores
        static MeiosMob()
        {
            listaMeios = new List<MeioMobilidade>();
        }
        #endregion

        #region Propriedades
        public List<MeioMobilidade> ListaMeios
        {
            get
            {
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
        public static bool InserirMeio(MeioMobilidade mm)
        {
            if (!listaMeios.Contains(mm))
            {
                listaMeios.Add(mm);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Permite apresentar na consola todos os meios da lista.
        /// </summary>
        public static void MostrarMeiosMobilidade()
        {
            foreach (MeioMobilidade mm in listaMeios)
            {
                {
                    Console.WriteLine(mm);
                }
            }

        }
        #endregion
    }
}
