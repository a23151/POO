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
    /// Enumerador - Existem apenas três tipos de modelo 
    /// </summary>
    enum Tipo
    {
        BICICLETA = 1,
        BICIELETRICA =5,
        TROTINETEELETRICA =10
    }
    /// <summary>
    /// Classe de modelo de veículo
    /// </summary>
    [Serializable]
    internal class Modelo
    {
        #region Atributos
        Tipo descricao;
        double preco;       // O preço vai ser especifico para cada meio. Como controlar?
        #endregion

        #region Construtores
        public Modelo( Tipo desc)
        {
            this.descricao = desc;
            this.preco = Valor(); 
        }

        //public Modelo(Tipo desc)
        //{
        //    this.descricao = desc;
        //}
        #endregion

        #region Propriedades

        public Tipo Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double Preco 
        {
            get { return preco; }
            set { preco = value; }
        }
        #endregion

        #region OutrosMetodos

        /// <summary>
        /// Devolve o preço/hora para cada modelo
        /// </summary>
        /// <returns></returns>
        public double Valor()
        {
            double valor;

            switch (descricao)
            {
                case Tipo.BICICLETA: valor = 0.5; break;
                case Tipo.BICIELETRICA: valor = 1; break;
                case Tipo.TROTINETEELETRICA: valor = 1; break;
                default: valor = 0; break;
            }
            return valor;
        }
            #endregion
        }
}
