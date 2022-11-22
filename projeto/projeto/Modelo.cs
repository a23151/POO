using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{

    enum Tipo
    {
        BICICLETA = 1,
        BICIELETRICA =2,
        TROTINETEELETRICA =3
    }
    internal class Modelo
    {
        #region Atributos
        //string designacao;
        Tipo descricao;
        int preco;
        int caucao;
        #endregion

        #region Construtores
        public Modelo(Tipo desc, int preco, int caucao)
        {
            this.descricao = desc;
            this.preco = preco;
            this.caucao = caucao; 
        }
        #endregion

        #region Propriedades

        // Como se faz para enum?
        //public Tipo Descricao
        //{
        //    get { return descricao; }
        //    set { descricao = value; }
        //}

        public int Preco
        {
           set { preco = value; }
        }

        public int Caucao
        {
            set { caucao = value; }
        }
        #endregion

        #region OutrosMetodos
        #endregion
    }
}
