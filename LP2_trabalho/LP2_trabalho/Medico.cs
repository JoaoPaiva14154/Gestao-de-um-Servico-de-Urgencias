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
    class Medico : FuncionarioMedico
    {
        #region ATRIB
        public string especialidade;
        int numMedico; //Numero
        int numDoentes = 0; //Terá que ter um limite por dia ou hora
        int numConsultorio;
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
            /// <param name="num">numero de medico</param>
        public Medico(string n, string p,string esp,int num) : base (n,p)
        {
            especialidade = esp;
            numMedico = num;
            
        }


        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Especialidade
        /// </summary>
        public string Especialidade
        {
            get { return especialidade ; }
            set { especialidade = value; }
        }

        /// <summary>
        /// Numero de Medico
        /// </summary>
        public int NumMedico
        {
            get { return numMedico; }
            set { numMedico = value; }
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
        /// Metodo para passar receitas, serve para enviar todos os medicamentos necessarios
        /// </summary>
        /// <param name="medico"></param>
        /// <param name="utente"></param>
        /// <returns></returns>
        public String PassarReceita(Medico medico, Utente utente)
        {
            int pReceita = 1;

            while (pReceita > 0)
            {
                Console.WriteLine("Quantos medicamentos para passar?");
                int b = int.Parse(Console.ReadLine());
                string[] temp = new string[b];

                if (b > 0)
                {
                    for (int i = 0; i <= b; i++)
                    {
                        Console.WriteLine("Nome do {1} Medicamento ", i + 1);
                        temp[i] = Console.ReadLine();
                    }
                    pReceita = -1;
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }

            
            

            /*
            if(FunçãoOficialDeReceita(medico.numMedico,medico.Nome,utente.Nome,Utente.CC,temp)==true )
            
            //esta função deverá ser a função oficial do hospital de acordo com a direção geral de saúde
            
            {
                //return Sucesso
            }
            */

                return null; //mudar quando tiver a função final 
        }


        /// <summary>
        /// Metodo para pedir um exame
        /// </summary>
        /// <param name="medico"></param>
        /// <param name="utente"></param>
        /// <returns></returns>

        
        public String PedirExame(Medico medico, Utente utente)       
        {

        /*

        int pExame = 1;

            while (pExame > 0)
            {
                Console.WriteLine("Qual o exame a fazer?");
                string exame1 = Console.ReadLine();
                pExame = -1;
            }

        return exame1;

        */

        return null; //mudar quando tiver a função final 

        }

        #endregion



    }
}
