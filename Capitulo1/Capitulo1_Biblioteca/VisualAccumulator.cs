using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MatplotlibCS;
using MatplotlibCS.PlotItems;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um acumulador visual. Este acumulador possui
    /// o efeito colateral de plotar os dados acumulados, bem como sua média.
    /// </summary>
    public class VisualAccumulator
    {
        private double total;
        private int N;
        private Figure plot;
        
        /// <summary>
        /// Média dos valores acumulados.
        /// </summary>
        public double Mean
        {
            get { return total / N; }
        }

        /// <summary>
        /// Objeto que representa um acumulador visual. Este acumulador possui
        /// o efeito colateral de plotar os dados acumulados, bem como sua média.
        /// </summary>
        /// <param name="trials">Quantidade de valores a serem acumulados.</param>
        /// <param name="max">Valor máximo a ser somado ao total.</param>
        public VisualAccumulator(int trials, double max)
        {
            
           plot = new Figure(1, 1)
           {
                FileName = "VisualAccumumator.png",
                OnlySaveImage = false,
                Subplots =
                {
                    new Axes(1)
                    {
                        Grid = new Grid()
                        {
                            XLim = new double[] {0, trials},
                            YLim = new double[] {0, max}
                        },
                        PlotItems = new List<PlotItem>()
                    }
                }
            };
        }

        /// <summary>
        /// Adiciona um valor ao total acumulado.
        /// </summary>
        /// <param name="val">Valor a ser acumulado.</param>
        public void addDataValue(double val)
        {
            total += val;
            N++;

            plot.Subplots[0].Title = this.ToString();
            plot.Subplots[0].PlotItems.Add(new Point2D(String.Empty, N, val)
            {
                Color = Color.Black,
                MarkerFaceColor = Color.Black,
                MarkerSize = 1
            });
            plot.Subplots[0].PlotItems.Add(new Point2D(String.Empty, N, Mean)
            {
                Color = Color.Red,
                MarkerFaceColor = Color.Red,
                MarkerSize = 1
            });
            
        }

        /// <summary>
        /// Exibe o gŕafico do acumulador.
        /// </summary>
        public void ShowGraphics()
        {
            MatplotlibCS.MatplotlibCS matplotlibCs = new MatplotlibCS.MatplotlibCS(@"/usr/bin/python3",
                @"/home/daniel/meus_repositorios/Sedgewick/Capitulo1/Capitulo1_Biblioteca/MatplotlibCS/matplotlib_cs.py",
                ".");

            Task t = matplotlibCs.BuildFigure(plot);
            t.Wait();
        }
        
        /// <summary>
        /// Retorna uma representação como string do acumulador.
        /// </summary>
        /// <returns>String que representa o acumulador.</returns>
        public override string ToString()
        {
            return String.Format("Mean ({0} values): {1}", N, Mean);
        }
    }
}