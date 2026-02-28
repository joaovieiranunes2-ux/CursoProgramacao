using System.Security.Cryptography.X509Certificates;

namespace CursoProgramacao
{
    public class Aula2
    {
        public void ValorPar()
        {

            int numero;
  
            Console.WriteLine("Informe um valor:");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }

        public void MaiorIdade()
        {
            int idade;

            Console.WriteLine("Informe sua idade:");


            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {

                Console.WriteLine("MAIOR DE IDADE");

            }
            else
            {

                Console.WriteLine("MENOR DE IDADE");
            }
        }
            
            public void Nota010()
        {
            int nota;

            Console.WriteLine("Informe sua nota que tirou:");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("APROVADO");
            }

            else if (nota >= 5) 
            {
                Console.WriteLine("RECUPERACAO");
            }

            else
            {
                Console.WriteLine("REPROVADO");
            }
            

        }


        }
    }
