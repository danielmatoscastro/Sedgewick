using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Capitulo1_Biblioteca
{
    public class RandomConnections
    {
        private const int LADO = 500;
        private const int RAIO = LADO / 2;
        
        private Bitmap bm = new Bitmap(LADO, LADO);
        private Pen pen = new System.Drawing.Pen(Brushes.Red);

        private int N;
        private double p;

        public RandomConnections(int N, double p)
        {
            this.N = N;
            this.p = p;
        }
        
        public void Run(string destino)
        {
            List<Point> pontos = GerarPontos();
            List<Tuple<Point, Point>> linhas = GerarLinhas(pontos);
            DesenharPontosELinhas(pontos, linhas);
            GerarImagem(destino);
        }

        private List<Point> GerarPontos()
        {
            List<Point> pontos = new List<Point>();

            double angulo = 2*Math.PI / N;

            for (int i = 0; i < N; i++)
            {
                Point ponto = i == 0 ? new Point(RAIO, 0) : Rotacionar(pontos[i - 1], angulo);
                pontos.Add(ponto);
            }

            for (int i = 0; i < N; i++)
            {
                Point pontoSemTransformacao = pontos[i];
                pontos[i] = new Point(pontoSemTransformacao.X + RAIO, pontoSemTransformacao.Y + RAIO);
            }

            return pontos;
        }

        private Point Rotacionar(Point posicaoAnterior, double angulo)
        {
            double xNovo = posicaoAnterior.X * Math.Cos(angulo) - posicaoAnterior.Y * Math.Sin(angulo);
            double yNovo = posicaoAnterior.X * Math.Sin(angulo) + posicaoAnterior.Y * Math.Cos(angulo);
            
            return new Point((int) Math.Round(xNovo), (int) Math.Round(yNovo));
        }

        private List<Tuple<Point, Point>> GerarLinhas(List<Point> pontos)
        {
            List<Tuple<Point, Point>> linhas = new List<Tuple<Point, Point>>();
            DistribuicaoBernoulli bernoulli = new DistribuicaoBernoulli(p);
            
            for (int i = 0; i < N-1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (bernoulli.Bernoulli())
                    {
                        Tuple<Point, Point> linha = new Tuple<Point, Point>(pontos[i], pontos[j]);
                        linhas.Add(linha);
                    }
                }
            }

            return linhas;
        }
        
        private void DesenharPontosELinhas(List<Point> pontos, List<Tuple<Point, Point>> linhas)
        {
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(Color.White);
                gr.DrawEllipse(pen, new Rectangle(0, 0, LADO, LADO));


                foreach (Point point in pontos)
                {
                    gr.DrawRectangle(new Pen(Brushes.Blue, 5), new Rectangle(point, new Size(1, 1)));
                }

                foreach (Tuple<Point, Point> linha in linhas)
                {
                    gr.DrawLine(new Pen(Brushes.Gray, 3), linha.Item1, linha.Item2);
                }
            }
        }
        
        private void GerarImagem(string destino)
        {
            bm.Save(destino, ImageFormat.Png);
        }
        
        
        
    }
}