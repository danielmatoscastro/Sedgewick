using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para obter representações de matrizes como strings.
    /// </summary>
    public class ImpressorMatricial
    {
        /// <summary>
        /// Produz uma representação como string de uma matriz.
        /// </summary>
        /// <typeparam name="T">Tipo de elementos da matriz.</typeparam>
        /// <param name="matriz">Matriz a ser representada como string.</param>
        /// <returns>Representação como string da matriz informada.</returns>
        public static string ImprimeMatriz<T>(T[][] matriz)
        {
            StringBuilder sb = new StringBuilder();

            int linhas = matriz.Count<T[]>();
            int colunas = matriz[0].Count<T>();

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    sb.Append(matriz[i][j].ToString());
                    sb.Append(" ");
                }

                sb.Append("\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Produz uma representação como string de uma matriz booleana.
        /// Os elementos true são representados como asterisco (*) e os elementos
        /// false como espaço ( ).
        /// </summary>
        /// <param name="matriz">Matriz a ser representada como string.</param>
        /// <returns>Representação como string da matriz informada.</returns>
        public static string ImprimeMatrizBooleana(bool[][] matriz)
        {
            StringBuilder sb = new StringBuilder();

            int linhas = matriz.Count<bool[]>();
            int colunas = matriz[0].Count<bool>();

            for (int i = -1; i < linhas; i++)
            {
                for (int j = -1; j < colunas; j++)
                {
                    if (i < 0)
                    {
                        sb.Append(j + 1);
                    }
                    else
                    {
                        if (j < 0)
                        {
                            sb.Append(i + 1);
                        }
                        else
                        {
                            if (matriz[i][j])
                            {
                                sb.Append("*");
                            }
                            else
                            {
                                sb.Append(" ");
                            }
                        }
                    }

                    sb.Append(" ");
                }

                sb.Append("\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Produz uma representação como string da transposta da matriz informada.
        /// </summary>
        /// <typeparam name="T">Tipo de elementos da matriz.</typeparam>
        /// <param name="matriz">Matriz cuja transposta será representada como string.</param>
        /// <returns>Representação como string da transposta da matriz informada.</returns>
        public static string ImprimeMatrizTransposta<T>(T[][] matriz)
        {
            StringBuilder sb = new StringBuilder();

            int linhas = matriz.Count<T[]>();
            int colunas = matriz[0].Count<T>();

            for (int i = 0; i < colunas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    sb.Append(matriz[j][i].ToString());
                    sb.Append(" ");
                }

                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
