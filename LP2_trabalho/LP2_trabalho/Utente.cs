/*      Trabalho Prático LP2
 *  |Gestão Urgência|
 * 
 *  José Paulo Antunes      a11582@alunos.ipca.pt
 *  João Paiva              a14154@alunos.ipca.pt
 *  
 *  IPCA 2019/2020
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace LP2_trabalho
{
    class Utente
    {
        #region ESTADO
        string nome;
        string estado;  //so no fim da triagem
        string regiao;
        string sexo;
        string numeroCartao;
        int idade;
        DateTime dataNasc;        
        DateTime dataDeEntrada;
        DateTime dataDeSaida;
        #endregion


        #region METODOS

        #region CONSTRUTORES
        //Métodos usados na criação de novos objectos

        /// <summary>
        /// Construtor com valores por defeito/omissão
        /// </summary>
        public Utente()
        {
            nome = "";
            estado = "";
            regiao = "";
            sexo = "";
        }

        /// <summary>
        /// Construtor com dados vindos do exterior
        /// </summary>
        /// <param name="n">Nome da Pessoa</param>
        /// <param name="r">Regiao da Pessoa</param>
        /// <param name="s"> sexo da Pessoa</param>
        /// <param name="dataNascim"> Data nascimento</param>
        /// <param name="cc"> numero cartao de cidadao</param>

        public Utente(string n, string r, string s,DateTime dataNascim,string cc)
        {
            
            nome = n;
            
            regiao = r;
            sexo = s;
            dataNasc = dataNascim;
            idade = (int.Parse(DateTime.Now.ToString("yyyyMMdd")) - int.Parse(dataNascim.ToString("yyyyMMdd"))) /10000 ;
            numeroCartao = cc;




        }


        #endregion



        #region PROPRIEDADES
        //Métodos usados para manipular atributos do Estado


        /// <summary>
        /// Manipula o atributo "nome"
        /// string nome;
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        /// <summary>
        /// Manupula o atributo "estado"
        /// string estado
        /// "doenteNormal, doenteRisco ou recuperado"
        /// </summary>
        public string Estado 
        {
            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Manipula o atributo "regiao"
        /// string regiao;
        /// </summary>
        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }

        /// <summary>
        /// Manipula o atributo "sexo"
        /// string sexo;
        /// </summary>
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        /// <summary>
        /// Data de Nascimento
        /// datetime 
        /// </summary>
        public DateTime DataDeNascimento
        {
            get { return dataNasc; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataNasc = value;
                }
            }
        }

        /// <summary>
        /// Data de entrada
        /// datetime 
        /// </summary>
        public DateTime DataDeEntrada
        {
            get { return dataDeEntrada; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataDeEntrada = value;
                }
            }
        }

       public int Idade 
        {
            get { return idade; }
            set 
            {
                idade = value;


            }
        }
        
        

        #endregion


        #endregion


        #region OVERRIDES
        public override string ToString()
        {
            return " Nome: " + nome + " Estado: " + estado;
        }
        #endregion

        /// <summary>
        /// Destrutor
        /// </summary>
        ~Utente()
        {

        }
    }
}
