/*      Trabalho Prático LP2
 *  |Gestão Urgência|
 * 
 *  José Paulo Antunes      a11582@alunos.ipca.pt
 *  João Paiva              a14154@alunos.ipca.pt
 *  
 *  IPCA 2019/2020
 */

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LP2_trabalho
{
    class FuncionarioMedico
    {
        #region ESTADO
        string nome;
        //DateTime dataNasc; // não precisa de ter data de nascimento o medico
        string posicao; //medico ou enfermeiro
        DateTime horarioDeEntrada;
        DateTime horarioDeSaida;
        #endregion


        #region METODOS

        #region CONSTRUTORES
        //Métodos usados na criação de novos objectos

        /// <summary>
        /// Construtor com valores por defeito/omissão
        /// </summary>
        public FuncionarioMedico()
        {
            nome = "";
            posicao = "";
        }

        /// <summary>
        /// Construtor com dados vindos do exterior
        /// </summary>
        /// <param name="p">Posicao da Pessoa</param>
        /// <param name="n">Nome da Pessoa</param>
        public FuncionarioMedico(string p, string n)
        {
            
            nome = n;
            posicao = p;
           
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
        ///Manupula o atributo posicao
        ///string posicao
        ///"medico ou enfermeiro"
        /// </summary>
        public string Posicao 
        {
            get { return posicao; }
            set { posicao = value; }
        }

        /// <summary>
        /// Horario de entrada
        /// datetime 
        /// </summary>
        public DateTime HorarioDeEntrada
        {
            get { return horarioDeEntrada; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    horarioDeEntrada = value;
                }
            }
        }

        /// <summary>
        /// Horario de saida
        /// datetime 
        /// </summary>
        public DateTime HorarioDeSaida
        {
            get { return horarioDeSaida; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    horarioDeSaida = value;
                }
            }
        }
        #endregion


        #endregion


        #region OVERRIDES
        public override string ToString()
        {
            return "Posicao: " + posicao + " Nome:" + nome;
        }
        #endregion

        /// <summary>
        /// Destrutor
        /// </summary>
        ~FuncionarioMedico()
        {

        }
    }
}
