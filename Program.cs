using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal valorTotal, renda, valorParcelado, maximoPermitido;
            int parcela;

            Console.WriteLine("-- Análise de Crédito --\n");

            Console.Write("Digite o valor solicitado..: ");
            valorTotal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade de parcelas: ");
            parcela = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a renda comprovada..: ");
            renda = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            valorParcelado = valorTotal / parcela;

            maximoPermitido = (30 * renda) / 100;

            Console.WriteLine($"Maior parcela permitida: {maximoPermitido:C}");
            Console.WriteLine();

            Console.WriteLine($"Empréstimo de {valorTotal:C}, dividido em {parcela}x de {valorParcelado:C}");
            Console.WriteLine();

            if(valorParcelado < maximoPermitido)
            {
                Console.Write("Empréstimo ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Autorizado");
                Console.ResetColor();
                Console.WriteLine("!");
            }
            else
            {
                Console.Write("Empréstimo ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Recusado");
                Console.ResetColor();
                Console.WriteLine("!");
            }
        }
    }
}
