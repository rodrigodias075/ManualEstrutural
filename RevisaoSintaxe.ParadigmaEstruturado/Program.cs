using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoSintaxe.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comentário de uma linha

            /*
             * Comentário de várias linha
             */

            //declaração de variáveis
            int idade = 43;
            float altura = 1.79f;
            decimal salario = 9000.50m;
            double media = 6.78;
            string nome = "Oh Neimá Jr.";

            //variáveis de referência
            Console.WriteLine(nome.ToLower());
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome);
            Console.WriteLine(nome.Substring(3));

            //Estuturas
            //Estrutura de Seleção

            if(idade >= 24) 
            {
                Console.WriteLine("Super Spineis Neimá JR."); 
            
            }
            //Se a Geovana acertar na mega sena
            //Muito Dinheiro --- Verdadeiro
            //Senão
            //Vai ter que trabalhar -- falso
            //tipo de inferência
            var vencedora = "Geovana";
            bool venceu = true;
            if(venceu)
            { 
                Console.WriteLine("É muito Dinheiro! para a: "+vencedora); 
            }
            else
            {
                Console.WriteLine(vencedora + " Vai ter que trabalhar!");
            }

            //switch (if compacto)
            var mes = 1;
            if (mes == 1) 
            {
                Console.WriteLine("janeiro");
            }else if(mes == 2)
            {
                Console.WriteLine("Fevereiro");
            }else if(mes == 3)
            {
                Console.WriteLine("Março");
            }
            else if (mes == 4)
            {
                Console.WriteLine("Abril");
            }
            else if (mes == 5)
            {
                Console.WriteLine("Maio");
            }
            else if (mes == 6)
            {
                Console.WriteLine("Junho");
            }
            else if (mes == 7)
            {
                Console.WriteLine("Julho");
            }
            else if (mes == 8)
            {
                Console.WriteLine("Agosto");
            }
            else if (mes == 9)
            {
                Console.WriteLine("Setembro");
            }
            else if (mes == 10)
            {
                Console.WriteLine("Outubro");
            }
            else if (mes == 11)
            {
                Console.WriteLine("Novembro");
            }
            else if (mes == 12)
            {
                Console.WriteLine("Dezembro");
            }
            else
            {
                Console.WriteLine("Não exitse esse valor");
            }

            switch (mes) 
            {
                case 1:Console.WriteLine("janeiro");break;
                case 2: Console.WriteLine("fevereiro");break;
                case 3: Console.WriteLine("março"); break;
                case 4: Console.WriteLine("abril"); break;
                case 5: Console.WriteLine("maio"); break;
                case 6: Console.WriteLine("junho"); break;
                case 7: Console.WriteLine("julho"); break;
                case 8: Console.WriteLine("agosto"); break;
                case 9: Console.WriteLine("setembro"); break;
                case 10: Console.WriteLine("outubro"); break;
                case 11: Console.WriteLine("novembro"); break;
                case 12: Console.WriteLine("dezembro"); break;
                default: Console.WriteLine("Dado inválido"); break;

            }
            int contador = 1;

            while(contador <=3)
            {
                Console.WriteLine("Rodrigo Neimá JR.");
                contador = contador + 1;
            }
            Console.WriteLine("===================Agora utilizando do while=============");

            do
            {
                Console.WriteLine("Rodrigo Neimá JR.");
                    contador = contador + 1;

            } while (contador <= 3);

            for (int i = 1; i <= 3; i = i + 1)
            {
                Console.WriteLine("Ô NEIMÁ");
            }





                Console.ReadKey();
        }
    }
}
