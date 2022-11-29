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
        Modelo modelo;
        public bool disponibilidade; //disponivel ou não  Faz sentido ser public?
        #endregion

        #region Construtores
        public MeioMobilidade(int idMeio)
        {
            this.idMeio = idMeio;
            this.disponibilidade = true;
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
        #endregion
    }
}
