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


    class Hospital
    {
        #region ATRIB
        int numeroTotalMedicos=0;
        int numeroTotalEnfermeiros = 0;
        public Medico[] totMed=new Medico[50];
        public Enfermeiro[] totEnf = new Enfermeiro[100];

        #endregion


        #region METODOS

        /// <summary>
        /// Adiciona enfermeiros ou medicos 
        /// </summary>
        /// <param name="nome">Nome</param>
        /// <param name="posicao">medico ou enfermeiro</param>
        /// <returns></returns>
        public bool AdicionaFuncionarioMedico(string nome, string posicao) 
        {

            if(posicao== "medico" || posicao == "med") 
            {
                Console.WriteLine("Qual o Numero de medico?");
                int aux1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual a Especialidade ?");
                string aux2 = Console.ReadLine();

                totMed[numeroTotalMedicos] = new Medico(nome, posicao, aux2, aux1);
                numeroTotalMedicos += 1;

                return true;
            }
            if (posicao == "enfermeiro" || posicao == "enf")
            {
                Console.WriteLine("Qual o Numero de Enfermeiro?");
                int aux1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual a Especialidade ?");
                string aux2 = Console.ReadLine();

                totEnf[numeroTotalEnfermeiros] = new Enfermeiro(nome, posicao, aux2, aux1);
                numeroTotalEnfermeiros += 1;

                return true;
            }

            else
            {
                return false;
            }
        }

        #endregion

    }
}
