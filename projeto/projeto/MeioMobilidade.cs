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
        bool disponibilidade; //disponivel ou não  (private pq é alterado qd é levantado/devolvido um pedido)

        #region Construtores
        public MeioMobilidade(int idMeio, Modelo modelo, bool disponibilidade)
        {
            this.idMeio = idMeio;
            this.modelo = modelo;
            this.disponibilidade = disponibilidade;
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

        public bool Disponibilidade
        {
            get { return disponibilidade; }
            set { disponibilidade = value; }  
        }  
        #endregion

        #region OutrosMetodos
        #endregion
    }
}
