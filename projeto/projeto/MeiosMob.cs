using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
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
