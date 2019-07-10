using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatplotlibCS;
using MatplotlibCS.PlotItems;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe com métodos estáticos para o cálculo de histograma.
    /// </summary>
    public class Histograma
    {
        /// <summary>
        /// Recebe uma amostra de inteiros e um valor limite M.
        /// Retorna o histograma dessa amostra, para valores entre 0 e M-1.
        /// </summary>
        /// <param name="a">Amostra.</param>
        /// <param name="M">Valor limite.</param>
        /// <returns>Histograma da amostra a, considerando valores entre 0 e M-1.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Lançada quando M é negativo ou zero.</exception>
        public static int[] GetHistograma(int[] a, int M)
        {
            if (M <= 0) throw new ArgumentOutOfRangeException("M", "O argumento M deve ser positivo.");

            int[] histograma = new int[M];

            foreach (int elemento in a)
            {
                if (0 <= elemento && elemento < M)
                {
                    histograma[elemento]++;
                }
            }

            return histograma;
        }

        /// <summary>
        /// Recebe uma amostra de doubles no intervalo (l, r). Calcula o histograma da amostra,
        /// dividido em N bins. 
        /// </summary>
        /// <param name="a">Amostra.</param>
        /// <param name="l">Limite inferior (excluso).</param>
        /// <param name="r">Limite superior (excluso).</param>
        /// <param name="N">Número de bins.</param>
        /// <returns>Histograma da amostra.</returns>
        public static double[] GetHistograma(double[] a, double l, double r, int N)
        {
            double[] histograma = new double[N];

            foreach (double elemento in a)
            {
                int binAdequado = EncontrarBinAdequado(elemento, l, r, N);
                histograma[binAdequado]++;
            }

            return histograma;
        }

        /// <summary>
        /// Dado um elemento de uma amostra no intervalo (l, r) dividida em N bins,
        /// calcula o bin adequado para este elemento.
        /// </summary>
        /// <param name="elemento">Elemento da amostra.</param>
        /// <param name="l">Limite inferior da amostra (excluso).</param>
        /// <param name="r">Limite superior da amostra (excluso).</param>
        /// <param name="N">Número do bins.</param>
        /// <returns>Bin adequado para o elemento.</returns>
        private static int EncontrarBinAdequado(double elemento, double l, double r, int N)
        {
            double tamanhoDoBin = CalcularTamanhoDoBin(l, r, N);
            return (int) Math.Floor(elemento / tamanhoDoBin);
        }

        /// <summary>
        /// Calcula o tamanho de um bin para uma amostra no intervalo (l, r) dividida em N bins.
        /// </summary>
        /// <param name="l">Limite inferior da amostra (excluso).</param>
        /// <param name="r">Limite superior da amostra (excluso).</param>
        /// <param name="N">Número de bins.</param>
        /// <returns>Tamanho do bin.</returns>
        private static double CalcularTamanhoDoBin(double l, double r, int N)
        {
            return Math.Ceiling((r - l) / N);
        }

        /// <summary>
        /// Dado uma amostra no intervalo (l, r), plota seu histograma dividido em N bins.
        /// Baseado no código em: https://github.com/ITGlobal/MatplotlibCS/tree/master/Examples
        /// </summary>
        /// <param name="a">Amostra no intervalo (l, r).</param>
        /// <param name="l">Limite inferior da amostra (excluso).</param>
        /// <param name="r">Limite superior da amostra (excluso).</param>
        /// <param name="N">Número de bins.</param>
        public static void PlotHistograma(double[] a, double l, double r, int N)
        {

            double[] histograma = GetHistograma(a, l, r, N);
            
            List<PlotItem> listaDePontos = GerarListaDePontos(l, r, N, histograma);

            MatplotlibCS.MatplotlibCS matplotlibCs = new MatplotlibCS.MatplotlibCS(@"/usr/bin/python3",
                @"/home/daniel/meus_repositorios/Sedgewick/Capitulo1/Capitulo1_Biblioteca/MatplotlibCS/matplotlib_cs.py",
                ".");

            Figure figure = new Figure()
            {
                FileName = @"/home/daniel/meus_repositorios/Sedgewick/ExampleHistogram.png",
                OnlySaveImage = false,
                DPI = 150,
                Subplots =
                {
                    new Axes(1, "The X axis", "The Y axis")
                    {
                        Title = "Histograma",
                        ShowLegend = false,
                        PlotItems = listaDePontos
                    },
                }
            };

            Task t = matplotlibCs.BuildFigure(figure);
            t.Wait();
        }

        /// <summary>
        /// Dado um histograma de uma amostra no intervalo (l, r) dividido em N bins,
        /// gera os pontos para o plot do gráfico.
        /// </summary>
        /// <param name="l">Limite inferior da amostra (excluso).</param>
        /// <param name="r">Limite superior da amostra (exlcuso).</param>
        /// <param name="N">Número de bins.</param>
        /// <param name="histograma">Histograma da amostra.</param>
        /// <returns>Lista de pontos para serem plotados.</returns>
        private static List<PlotItem> GerarListaDePontos(double l, double r, int N, double[] histograma)
        {
            List<PlotItem> listaDePontos = new List<PlotItem>();
            double tamanhoDoBin = CalcularTamanhoDoBin(l, r, N);
            
            for (int i = 0; i < N; i++)
            {
                Point2D ponto = new Point2D(String.Empty, l + i * tamanhoDoBin, histograma[i]);
                listaDePontos.Add(ponto);
            }

            return listaDePontos;
        }
    }
}
