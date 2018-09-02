using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variaveis 
            double bruto, segSocial, irs, liquido;

            //obtencao de dados
            Console.Write("Salário Bruto:");
            bruto = double.Parse(Console.ReadLine());

            //Calculos
            segSocial = bruto * 0.2;

            if (bruto < 500)
            {
                irs = 0;
            }
            else if(bruto>=500 && bruto <1000)
            {
                irs = bruto * 0.12;
            }
            else if(bruto>=1000 && bruto < 1500)
            {
                irs = bruto * 0.15;
            }
            else
            {
                irs = bruto * 0.18;
            }

            liquido = bruto - segSocial - irs;

            //Apresentação do resultado

            Console.WriteLine("Liquido: " + liquido);
            Console.Read();
          
        }
    }
}
