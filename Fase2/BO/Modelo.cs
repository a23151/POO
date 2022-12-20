using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Enumerador - Existem apenas três tipos de modelo 
    /// </summary>
    public enum Tipo
    {
        BICICLETA = 1,
        BICIELETRICA = 5,
        TROTINETEELETRICA = 10
    }
    public class Modelo
    {
        #region Atributos
        Tipo descricao;
        double preco;       // O preço vai ser especifico para cada meio. Como controlar?
        #endregion

        #region Construtores
        public Modelo(Tipo desc)
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
