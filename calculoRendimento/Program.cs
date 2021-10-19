using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoRendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular valor investido em 12 meses.


            Console.WriteLine("Cálculo de juros mensais");
            Console.WriteLine("");

            Console.Write("Qual o valor que será aplicado: ");
            double valorAplicado = double.Parse(Console.ReadLine());

            Console.Write("Certo. No que você quer investir? Ex.: CDB, LCA, LCI, FIIS, etc: ");
            string tipoInvestimento = Console.ReadLine();

            Console.Write("E qual o rendimento a.m? ");
            double jurosInvestimento = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Entendi... Vamos calcular quanto renderá em 12 meses...");

            Console.WriteLine("");
            Console.WriteLine($"{tipoInvestimento} com rendimento de {jurosInvestimento} a.m.");

            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorAplicado = (valorAplicado + valorAplicado * jurosInvestimento);
                Console.WriteLine($"Mes {contadorMes}: R${Math.Round(valorAplicado, 2)}");
                contadorMes++;
            }

            Console.WriteLine("");
            Console.WriteLine("Tecle ENTER para finalizar.");
            Console.ReadLine();
        }
    }
}
