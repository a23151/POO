using BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    /// <summary>
    /// Classe que permite guardar os utilizadores numa lista.
    /// </summary>
    public class Utilizadores
    {
        #region Atributos
        static List<Utilizador> listaUtilizadores;
        #endregion

        #region Construtores
        static Utilizadores()
        {
            listaUtilizadores = new List<Utilizador>();
        }
        #endregion

        #region Propriedades
        public List<Utilizador> ListaUtilizadores
        {
            get
            {
                List<Utilizador> copiaU = new List<Utilizador>(listaUtilizadores);
                return copiaU;
            }
            set { listaUtilizadores = value; }
        }
        #endregion

        #region OutrosMetodos
        /// <summary>
        /// Metodo que permite inserir um utilizador na lista, caso ainda não exista.
        /// </summary>
        /// <param name="ut"></param>
        /// <returns></returns>
        public static bool InserirUtilizador(Utilizador ut)
        {
            if (!listaUtilizadores.Contains(ut))
            {
                listaUtilizadores.Add(ut);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo que permite criar utilizadores a partir de um ficheiro (com os atributos) e adicionar à lista.
        /// Utiliza um vetor auxiliar para guardar os dados de cada utilizador.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool InserirUtilizadorFicheiro(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] atributos = sr.ReadLine().Split(',');
                    int numero = int.Parse(atributos[0]);
                    string nome = atributos[1];
                    InserirUtilizador(new Utilizador(numero, nome));
                }
                return true;
            }
        }
        #endregion
    }
}
