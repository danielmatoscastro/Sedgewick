using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.10.
    /// </summary>
    public class Exercicio1210_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random(DateTime.Now.Millisecond);
                VisualAccumulator visualAccumulator = new VisualAccumulator(2000, 1.0);

                for (int i = 0; i < 2000; i++)
                {
                    visualAccumulator.addDataValue(random.NextDouble());
                }
                
                visualAccumulator.ShowGraphics();
                Console.WriteLine(visualAccumulator);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}