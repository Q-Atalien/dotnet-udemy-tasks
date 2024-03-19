using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
   class SaidadeDados
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine($"Produtos:\n{produto1} cujo o preço é $ {preco1}\n" +
                $"{produto2}, cujo preco é $ {preco2}\n\n" +
                $"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n\n" +
                $"Medida com oito casas decimais: {medida:F8}\n" +
                $"Arredondado (três casas decimais): {medida:F3}\n" +
                $"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
