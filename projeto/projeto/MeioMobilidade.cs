using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    internal class MeioMobilidade
    {
        #region Atributos
        int idMeio;
        //string descricao
        Tipo modelo;
        bool disponibilidade; //disponivel ou não
        #endregion

        #region Construtores
        public MeioMobilidade(int idMeio)
        {
            this.idMeio = idMeio;
            this.disponibilidade = true;
        }
        #endregion

        #region Propriedades

        // ---> COMPLETAR <----
        #endregion

        #region OutrosMetodos
        #endregion
    }
}
