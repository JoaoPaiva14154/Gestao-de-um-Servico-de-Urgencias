using System;
using System.Collections.Generic;
using System.Text;

namespace LP2_trabalho
{
    class Enfermeiro : FuncionarioMedico
    {
        #region ATRIB
        public string especialidade;
        int numEnfermeiro; //Numero
        bool naUrgencia = false;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Métodos usados na criação de novos objectos

        /// <summary>
        /// Construtor de medico
        /// </summary>
        /// <param name="n">nome</param>
        /// <param name="p">Posicao</param>
        /// <param name="esp">especialidade</param>
        /// <param name="num">numero de enfermeiro</param>

        public Enfermeiro(string n, string p, string esp, int num) : base(n, p)
        {
            especialidade = esp;
            numEnfermeiro = num;
        }


        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Especialidade
        /// </summary>
        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }

        /// <summary>
        /// Numero de Enfermeiro
        /// </summary>
        public int NumEnfermeiro
        {
            get { return numEnfermeiro; }
            set { numEnfermeiro = value; }
        }

        /// <summary>
        /// Situaçao urgencia
        /// </summary>
        public bool NaUrgencia
        {
            get { return naUrgencia; }
            set { naUrgencia = value; }
        }

        #endregion

        /// <summary>
        /// Metodo para fazer um exame, serve para efetuar os exames requeridos pelos médicos
        /// </summary>
        /// <param name="enfermeiro"></param>
        /// <param name="utente"></param>
        /// <returns></returns>
        public String FazerExame(Enfermeiro enfermeiro, Utente utente, string exame)
        {
            return null; //mudar quando tiver a função final 
        }



        #endregion



    }
}
