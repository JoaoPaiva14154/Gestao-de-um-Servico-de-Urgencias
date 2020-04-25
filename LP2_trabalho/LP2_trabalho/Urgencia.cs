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
    class Urgencia : Hospital
    {

        #region ATRIB
        int numeroDeUtentes = 0;
        int numeroDeMedicos = 0;
        int numeroDeEnfermeiros = 0;
        Utente[] totUtente = new Utente[50];
        Medico[] medDeUrgencia = new Medico[10];
        Enfermeiro[] enfDeUrgencia = new Enfermeiro[30]; 

        #endregion

        #region METODOS
        /// <summary>
        /// adiciona utente
        /// </summary>
        /// <returns></returns>
        public void AdicionaUtente()
        {

            Console.WriteLine("Nome do Utente");
            string nome = Console.ReadLine();
            Console.WriteLine("Região do utente");
            string regiao = Console.ReadLine();
            Console.WriteLine("Sexo do utente");
            string sexo = Console.ReadLine();
            Console.WriteLine("Data de Nascimento ");
            Console.WriteLine("Ano");
            int aux1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes");
            int aux2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dia");
            int aux3 = int.Parse(Console.ReadLine());
            DateTime dataNascimento = new DateTime(aux1,aux2,aux3);


            totUtente[numeroDeUtentes] = new Utente(nome, regiao, sexo, dataNascimento, DateTime.Now.ToString());
            totUtente[numeroDeUtentes].Idade = (int.Parse(DateTime.Now.ToString("yyyyMMdd")) - int.Parse(dataNascimento.ToString("yyyyMMdd"))) / 10000;

            
        }
        /// <summary>
        /// De serviço para Medico ou enfermeiro
        /// </summary>
        /// <param name="posicao">Medico ou enf</param>
        public void DeServicoNaUrgencia(string posicao) 
        {
            if (posicao == "medico" || posicao == "med")
            {
                Console.WriteLine("Qual o numero do medico que vai entrar na urgencia?");
                int aux = int.Parse(Console.ReadLine());
                for (int i = 0; i < totMed.Length; i++)
                {
                    if (aux == totMed[i].NumMedico)
                    {
                        totMed[i].NaUrgencia = true;  //vai modificar informaçao ao get set

                        medDeUrgencia[numeroDeMedicos] = totMed[i];

                        numeroDeMedicos += 1;

                    }

                }
            }

            else if(posicao == "enfermeiro" || posicao == "enf") 
            {

                Console.WriteLine("Qual o numero do Enfermeiro que vai entrar na urgencia?");
                int aux = int.Parse(Console.ReadLine());
                for (int i = 0; i < totMed.Length; i++)
                {
                    if (aux == totEnf[i].NumEnfermeiro)
                    {
                        totEnf[i].NaUrgencia = true;  //vai modificar informaçao ao get set

                        enfDeUrgencia[numeroDeEnfermeiros] = totEnf[i];

                        numeroDeEnfermeiros += 1;

                    }

                }

            }

        }
       


        #endregion  



    }
}
