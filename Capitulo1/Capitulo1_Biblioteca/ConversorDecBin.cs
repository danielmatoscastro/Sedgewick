using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para conversão de Decimal para Binário.
    /// </summary>
    public class ConversorDecBin
    {
        /// <summary>
        /// Converte um inteiro positivo em sua representação binária.
        /// </summary>
        /// <param name="numDecimal">Número a ser convertido.</param>
        /// <returns>Representação binária do número informado.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Lançada quando o argumento é negativo.</exception>
        public static string Converter(int numDecimal)
        {
            if (numDecimal < 0) throw new ArgumentOutOfRangeException("numDecimal", "Argumento deve ser não negativo");

            if (numDecimal == 0)
            {
                return "0";
            }

            StringBuilder sb = new StringBuilder();

            while (numDecimal > 0)
            {
                if (numDecimal % 2 == 0)
                {
                    sb.Append("0");
                }
                else
                {
                    sb.Append("1");
                }

                numDecimal /= 2;
            }

            return new String(sb.ToString().Reverse().ToArray());
        }
    }
}
