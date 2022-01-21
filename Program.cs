using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imprime na tela
            //
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "Ubuntu1 Silva";
            int idade1   = 33;
            double peso1 = 88.50;
            decimal altura1 = 1.65M;
            bool EhDev1  = true;

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            decimal altura2 = 2.10M;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            decimal altura3 = 1.40M;
            bool EhDev3 = false;


            //GO!

            Console.WriteLine("VIZUALIZAÇÃO DE DADOS DOS UBUNTUS.");
            
            Console.WriteLine();

            Console.WriteLine("Aperte enter para vizualizar a soma total da idade dos ubuntus.");

            Console.ReadLine();


            //T1 - Somar a idade de todos Ubuntus


            Console.WriteLine("A soma da idade dos ubuntus é");

            Console.WriteLine();

            Console.WriteLine(idade1 + idade2 + idade3);

            Console.WriteLine();

            Console.WriteLine("Aperte enter para vizualizar os nomes dos ubuntus.");

            Console.WriteLine();

            Console.ReadLine();


            //T2 - Agrupar os nomes de todos Ubuntus

            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);

            Console.WriteLine();

            Console.WriteLine("Aperte enter para saber a média de imc dos ubuntus");

            Console.WriteLine();

            Console.ReadLine();


            //T3 - Calcular Média dos IMC de todos Ubuntus

            Console.WriteLine("Esse é o IMC de");
            Console.WriteLine(nome1);

            float peso1outro = Convert.ToSingle(peso1);
            float altura1outro = Convert.ToSingle(altura1);
            

            Console.WriteLine(peso1outro / (altura1outro * altura1outro ));

            Console.WriteLine();

            Console.WriteLine("Esse é o IMC de");
            Console.WriteLine(nome2);

            float peso2outro = Convert.ToSingle(peso2);
            float altura2outro = Convert.ToSingle(altura2);


            Console.WriteLine(peso2outro / (altura2outro * altura2outro));

            Console.WriteLine();

            Console.WriteLine("Esse é o IMC de");
            Console.WriteLine(nome3);

            float peso3outro = Convert.ToSingle(peso3);
            float altura3outro = Convert.ToSingle(altura3);


            Console.WriteLine(peso3outro / (altura3outro * altura3outro));

            Console.WriteLine();


            Console.WriteLine("Aperte enter para saber quantos ubuntus são devs");



            Console.WriteLine();

            Console.ReadLine();

            





            //T4 - Contar quantos Ubuntus sao Devs




            if (EhDev1 == true)
            {
                Console.WriteLine(nome1);
                Console.WriteLine("É dev.");

            }

            else
            {
                Console.WriteLine(nome1);
                Console.WriteLine("não é dev.");
            }


            Console.WriteLine();

            if (EhDev2 == true)
            {
                Console.WriteLine(nome2);
                Console.WriteLine("É dev.");

            }

            else
            {
                Console.WriteLine(nome2);
                Console.WriteLine("não é dev.");
            }


            Console.WriteLine();



            if (EhDev3 == true)
            {
                Console.WriteLine(nome3);
                Console.WriteLine("É dev.");

            }

            else
            {
                Console.WriteLine(nome3);
                Console.WriteLine("não é dev.");
            }


            Console.WriteLine();


            Console.WriteLine("aperte enter para mostrar os Ubuntus com sobrenome Silva");

            Console.ReadLine();



            //T5 - Exibir somente Ubuntu com nome Silva


            if (nome1.Trim().EndsWith("Silva"))
                
                {

                Console.WriteLine(nome1);

                }

            else

            {

                Console.WriteLine();

            }


            Console.WriteLine();


            if (nome2.Trim().EndsWith("Silva"))

            {

                Console.WriteLine(nome2);

            }

            else

            {

                Console.WriteLine();

            }


            Console.WriteLine();


            if (nome3.Trim().EndsWith("Silva"))

            {

                Console.WriteLine(nome3);

            }

            else

            {

                Console.WriteLine();

            }


            Console.WriteLine();

            Console.WriteLine("PRESSIONE ENTER PARA SAIR DO PROGRAMA");
            
            
            Console.ReadKey();








            //Imprime na tela
            //Console.WriteLine("A soma de idade de todos os Ubuntus é:");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            //Console.WriteLine();

            
        }


    }
}
